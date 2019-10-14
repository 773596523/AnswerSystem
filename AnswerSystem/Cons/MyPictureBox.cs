using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnswerSystem.Cons
{
    public class MyPictureBox : PictureBox
    {
        public MyPictureBox()
        {
            this.DoubleBuffered = true;
        }

        public p_WindProc p_Wind;
        /// 拖动大小
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0201://鼠标左键按下的消息 用于实现拖动窗口功能
                    if (p_Wind != null)
                        p_Wind.Invoke(ref m);
                    break;
            }

            base.WndProc(ref m);
        }
    }
}
