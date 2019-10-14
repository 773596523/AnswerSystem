using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using AnswerSystem.Helper;

namespace AnswerSystem.Cons
{
    public class MyTextBox : TextBox
    {
        public MyTextBox()
        {
            InitializeComponent();

        }
        public HashSet<string> hs_autocom = new HashSet<string>();
        public void Init()
        {
            try
            {
                hs_autocom = hs_autocom.DeSerializableObject(this.Name);
                if (hs_autocom != null && hs_autocom.Count > 0)
                {
                    var monthList = new AutoCompleteStringCollection();
                    monthList.AddRange(hs_autocom.ToArray());
                    this.AutoCompleteCustomSource = monthList;
                    this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    this.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            catch (Exception ex)
            {
                LogHelper.writeLog(ex);
            }
        }
        public void End()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.Text.Trim()))
                {
                    hs_autocom.Add(this.Text.Trim());
                }

                hs_autocom.SerializableObject(this.Name);
            }
            catch (Exception ex)
            {
                LogHelper.writeLog(ex);
            }
           
        }

        protected override void Dispose(bool disposing)
        {
            End();
            //
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyTextBox
            // 
            this.VisibleChanged += new System.EventHandler(this.MyTextBox_VisibleChanged);
            this.ResumeLayout(false);

        }

        private void MyTextBox_VisibleChanged(object sender, EventArgs e)
        {
            Init();
        }
    }
}
