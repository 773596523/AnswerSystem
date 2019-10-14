using AnswerSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnswerSystem.IBLL
{
    public interface IReadLoader
    {
        List<Topic> Reads(SubjectEnum subjectEnum, Student student);
    }
}
