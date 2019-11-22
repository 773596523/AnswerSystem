using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnswerSystemWPF.Helper;
using AnswerSystemWPF.IBLL;

namespace AnswerSystemWPF.Body
{
    [Serializable]
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public ExaminationPaper ExaminationPaper { get; set; }

        public bool IsValid
        {
            get
            {
                bool flag = ConvExtension.IsNullOrWhiteSpace(StudentID, Name);

                return flag;
            }
        }

    }
}
