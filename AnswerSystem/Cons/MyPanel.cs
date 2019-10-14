using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnswerSystem.Cons
{
    public class MyPanel : Panel
    {
        public MyPanel()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | //不擦除背景 ,减少闪烁
                          ControlStyles.OptimizedDoubleBuffer | //双缓冲
                          ControlStyles.UserPaint, //使用自定义的重绘事件,减少闪烁
                          true);
        }

        public string Content { get; set; }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyPanel
            // 
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPanel_Paint);
            this.ResumeLayout(false);

        }

        private void MyPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };

            RectangleF rec = new RectangleF()
            {
                Width = this.Width,
                Height = this.Height
            };

            g.DrawString(Content, this.Font, new SolidBrush(this.ForeColor), rec, sf);
        }
    }
}
