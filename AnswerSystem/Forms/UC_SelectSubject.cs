using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnswerSystem.Model;

namespace AnswerSystem.Forms
{
    public partial class UC_SelectSubject : UserControl
    {

        public UC_SelectSubject()
        {
            InitializeComponent();
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

        private void btnSubjectNet_Click(object sender, EventArgs e)
        {
            UC_Examination uc = new UC_Examination(SubjectEnum.Net);
            AppSetting.FrmHome.LoadControl(uc);
        }

        private void btnSubjectJava_Click(object sender, EventArgs e)
        {
            UC_Examination uc = new UC_Examination(SubjectEnum.Java);
            AppSetting.FrmHome.LoadControl(uc);
        }
    }
}
