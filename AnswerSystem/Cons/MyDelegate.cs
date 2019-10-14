using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnswerSystem.Cons
{
    public class MyDelegate
    {
       
    }

    public delegate void p_WindProc(ref Message m);
    public delegate void p_ProcessCmdKey(ref Message msg, Keys keyData);
}
