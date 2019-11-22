using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Data;
using AnswerSystemWPF.Body;
using AnswerSystemWPF.Helper;
using AnswerSystemWPF.IBLL;

namespace AnswerSystemWPF.BLL
{
    public class TxtReadLoader : IReadLoader
    {

        ObservableCollection<Topic> IReadLoader.Reads(SubjectEnum subjectEnum, Student student)
        {
            //获取题目
            string problems = "";
            string type = "";

            switch (subjectEnum)
            {
                case SubjectEnum.Net:
                    problems = Properties.Resources.Net试题;
                    type = "Net";
                    break;
                case SubjectEnum.Java:
                    problems = Properties.Resources.Java试题;
                    type = "Java";
                    break;
            }

            string regex = @"<problems>(.*?)</problems>";

            var matchs = Regex.Matches(problems, regex);

            int index = 1;
            var obj = (from Match m in matchs
                       select m.Value.Replace("<problems>", "").Replace("</problems>", "").Trim() into problem
                       where !string.IsNullOrWhiteSpace(problem)
                       select new Topic() { Problem = problem, AnSwer = "", Index = index++ }).ToList();
            ObservableCollection<Topic> lis = new ObservableCollection<Topic>(obj);

            //获取学生作答情况
            if (student != null && !string.IsNullOrEmpty(student.StudentID))
            {
                lis = lis.DeSerializableObject($@"{type}_{student.StudentID}_{student.Name}_{AppSetting.ComputerInfo}");
            }

            return lis;
        }

    }
}
