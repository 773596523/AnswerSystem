using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnswerHandle.Model
{
    [Serializable]
    public class Topic
    {
        public string Problem { get; set; }
        public string AnSwer { get; set; }
    }
}