using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Navigation;
using AnswerSystemWPF.ViewModel;

namespace AnswerSystemWPF.Body
{
    [Serializable]
    public class Topic
    {
        public int Index { get; set; }
        public string Problem { get; set; }
        public string AnSwer { get; set; }
    }


}
