using AnswerSystem.Forms;
using AnswerSystem.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnswerSystem
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            this.MaximizedBounds = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            AppSetting.FrmHome = this;
            LoadSelectSubject();
        }


        public void LoadSelectSubject()
        {
            UC_SelectSubject uc = new UC_SelectSubject
            {
                Width = this.plMain.Width,
                Height = this.plMain.Height
            };
            LoadControl(uc);
        }
        public void LoadControl(Control con, bool is_del = true)
        {
            if (con == null)
            {
                LoadSelectSubject();
            }
            else
            {
                if (is_del)
                {
                    this.plMain.Controls.Clear();
                }
               
                con.Dock = DockStyle.Fill;
                con.BringToFront();
                this.plMain.Controls.Add(con);
                con.Focus();
            }
        }

        // 防止闪屏
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


        protected override void WndProc(ref Message m)
        {
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 0x10;
            const int HTBOTTOMRIGHT = 17;


            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF, (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else m.Result = (IntPtr)HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOM;
                    break;
                case 0x0201://鼠标左键按下的消息 用于实现拖动窗口功能
                    m.Msg = 0x00A1;//更改消息为非客户区按下鼠标
                    m.LParam = IntPtr.Zero;//默认值
                    m.WParam = new IntPtr(2);//鼠标放在标题栏内
                    base.WndProc(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void frmHome_Shown(object sender, EventArgs e)
        {
            this.lblStudentID.Text = AppSetting.Student.StudentID;
            this.lblStudentName.Text = AppSetting.Student.Name;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认要退出考试吗?", "系统提示",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }


    }
}
