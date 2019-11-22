using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using AnswerSystemWPF.Body;

namespace AnswerSystemWPF.IBLL
{
    public interface IReadLoader
    {
        ObservableCollection<Topic> Reads(SubjectEnum subjectEnum, Student student);
    }
}
