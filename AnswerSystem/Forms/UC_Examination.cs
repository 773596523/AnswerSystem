using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnswerSystem.Model;
using AnswerSystem.IBLL;
using AnswerSystem.BLL;
using System.Drawing.Drawing2D;
using AnswerSystem.Cons;
using AnswerSystem.Helper;

namespace AnswerSystem.Forms
{
    public partial class UC_Examination : UserControl
    {
        public UC_Examination() { }
        public UC_Examination(SubjectEnum subjectEnum)
        {
            InitializeComponent();

            Init(subjectEnum);
        }

        public IReadLoader read = new TxtReadLoader();
        public ExaminationPaper Examination { get; set; }
        public List<Cell> cells = new List<Cell>();
        public int topic_index = 0;


        public void Init(SubjectEnum subjectEnum)
        {
            Examination = new ExaminationPaper()
            {
                SubjectEnum = subjectEnum,
                Student = AppSetting.Student,
                CompleteTime = null
            };
            Examination.LoadTopics(read);

            if (subjectEnum == SubjectEnum.Net)
            {
                this.lblTitle.Text = "Net试题";
            }
            else if (subjectEnum == SubjectEnum.Java)
            {
                this.lblTitle.Text = "Java试题";
            }

            SetTopic(null);
        }

        public void SetTopic(int? index)
        {
            if (index < 0 || index >= Examination.Topics.Count)
            {
                return;
            }

            if (index.HasValue)
            {
                topic_index = index.Value;
                var topic = Examination.Topics[topic_index];
                this.lblProblem.Text = (topic_index + 1) + ". " + topic.Problem;
                this.txtAnswer.Text = topic.AnSwer;
                this.txtAnswer.Select(this.txtAnswer.TextLength, 0);
                this.txtAnswer.Focus();
            }
            else
            {
                int i = 0;
                Examination.Topics.ForEach((t) =>
                {
                    if (string.IsNullOrEmpty(t.AnSwer))
                    {
                        return;
                    }
                    i++;
                });
                if (i == Examination.Topics.Count)
                {
                    SetTopic(0);
                }
                else
                {
                    SetTopic(i);
                }

            }


            this.plAnswer.Refresh();
        }

        public void AnswerPanit(Graphics g)
        {
            cells.Clear();

            int width = this.plAnswer.Width;
            int height = this.plAnswer.Height;

            int cell_left = 3;
            int cell_right = 3;
            int cell_top = 3;
            int cell_bot = 3;
            int cell_w = 30;
            int cell_h = 30;

            StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };

            int index = 0;
            int m_top = 0;

            while (index < Examination.Topics.Count)
            {
                int m_left = 0;
                for (int i = 0; i < 6; i++)
                {
                    Rectangle rec = new Rectangle(m_left + cell_left, m_top + cell_top, cell_w, cell_h);

                    Image img = Properties.Resources.btn;
                    if (index == this.topic_index)
                    {
                        img = Properties.Resources.btn3;
                    }
                    else if (string.IsNullOrEmpty(Examination.Topics[index].AnSwer))
                    {
                        img = Properties.Resources.btn;
                    }
                    else if (!string.IsNullOrEmpty(Examination.Topics[index].AnSwer))
                    {
                        img = Properties.Resources.btn2;
                    }

                    g.DrawImage(img, rec);
                    g.DrawString((index + 1).ToString(), plAnswer.Font, new SolidBrush(plAnswer.ForeColor), rec, sf);

                    cells.Add(new Cell(index, rec));
                    m_left += cell_left + cell_w + cell_right;
                    index++;

                    if (index >= Examination.Topics.Count)
                    {
                        break;
                    }
                }

                m_top += cell_top + cell_h + cell_bot;
            }



        }

        private void plAnswer_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                e.Graphics.TranslateTransform(plAnswer.AutoScrollPosition.X, plAnswer.AutoScrollPosition.Y);
                AnswerPanit(e.Graphics);
            }
            catch (Exception)
            {
            }
        }

        private void plAnswer_MouseMove(object sender, MouseEventArgs e)
        {
            var cell = cells.SingleOrDefault(c => c.rec.Contains(e.X, e.Y));
            if (cell != null)
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void plAnswer_MouseDown(object sender, MouseEventArgs e)
        {
            var cell = cells.FirstOrDefault(c => c.rec.Contains(e.X, e.Y));
            if (cell != null)
            {
                SetTopic(cell.index);
            }
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            if (Examination.Topics.Count < 1 || topic_index >= Examination.Topics.Count) return;

            Examination.Topics[topic_index].AnSwer = this.txtAnswer.Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SetTopic(topic_index + 1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            SetTopic(topic_index - 1);
        }

        private void tmAutoSave_Tick(object sender, EventArgs e)
        {
            Examination.SaveTopics();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((msg.Msg == 0x100) || (msg.Msg == 0x104))
            {
                switch (keyData)
                {
                    case Keys.S | Keys.Control:
                        Examination.SaveTopics();
                        break;
                    case Keys.PageUp:
                        btnPrev_Click(null, null);
                        break;
                    case Keys.PageDown:
                        btnNext_Click(null, null);
                        break;
                    default:
                        return base.ProcessCmdKey(ref msg, keyData);
                }
            }

            return true;
        }


        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Cancel | Keys.S:
                    Examination.SaveTopics();
                    break;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AppSetting.FrmHome.LoadSelectSubject();
        }

        public void Upload()
        {
            Request r = new Request();

            r.Write("FileName", Examination.GetFIleName());
            r.Write("FileData", Examination.Topics);
            r.Write("Title", Examination.SubjectEnum.ToString());
            r.Write("Info",Examination.GetInfo());

            r.request("/Home/UploadExam");

            if (!r.ReadSuccess())
            {
                throw new Exception(r.ReadMessage());
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (Examination.ExamNullTopic())
                {
                    if (MessageBox.Show("你有题目未答完,确定要上传吗?", "提示",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                }

                this.Cursor = Cursors.WaitCursor;
                Upload();
                this.Cursor = Cursors.Default;
                MessageBox.Show("上传完成");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void UC_Examination_Resize(object sender, EventArgs e)
        {
            this.lblProblem.MaximumSize = new Size(this.myPanel2.Width, 0);
            this.lblProblem.MinimumSize = new Size(this.myPanel2.Width, 0);
        }
    }
}
