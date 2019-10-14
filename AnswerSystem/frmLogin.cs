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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            Init();
        }

        public HashSet<string> hs_StudentID = new HashSet<string>();
        public HashSet<string> hs_Name = new HashSet<string>();

        public void Init()
        {
            this.tlpTop.p_Wind += WndProc;
            this.pbTitle.p_Wind += WndProc;
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

        /// 拖动大小
        protected override void WndProc(ref Message m)
        {
            m.HWnd = this.Handle;
            switch (m.Msg)
            {
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


        public DialogResult GoLogin()
        {
            return this.ShowDialog();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtStudentID.Text.Trim()) || string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                MessageBox.Show("请补全信息");
                return;
            }

            AppSetting.Student.StudentID = this.txtStudentID.Text;
            AppSetting.Student.Name = this.txtName.Text;

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            this.txtStudentID.Focus();
        }

        private void txtStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtName.Focus();
            }
        }
        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (KeyPressJudge.IsEnglish(e.KeyChar) || KeyPressJudge.IsBackKey(e.KeyChar) || KeyPressJudge.IsKeyBord(e.KeyChar) ||
                KeyPressJudge.IsEnter(e.KeyChar) || KeyPressJudge.IsNum(e.KeyChar) || e.KeyChar == 8 || Char.IsDigit(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnYes_Click(sender, e);
            }
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (KeyPressJudge.IsStr(e.KeyChar) || KeyPressJudge.IsBackKey(e.KeyChar) || e.KeyChar == 8 || Char.IsDigit(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }



    }
}
