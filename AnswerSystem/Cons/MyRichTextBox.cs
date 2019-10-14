using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AnswerSystem.Cons
{
    public class MyRichTextBox : RichTextBox
    {
        #region 透明背景
        //[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        //static extern IntPtr LoadLibrary(string lpFileName);

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams prams = base.CreateParams;
        //        if (LoadLibrary("msftedit.dll") != IntPtr.Zero)
        //        {
        //            prams.ExStyle |= 0x020; // transparent 
        //            prams.ClassName = "RICHEDIT50W";// TRANSTEXTBOXW
        //        }
        //        return prams;
        //    }
        //}
        #endregion
    }
}
