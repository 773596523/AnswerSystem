using AnswerSystem.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using AnswerSystem.Model;
using AnswerSystem.Helper;

namespace AnswerSystem.BLL
{
    public class TxtReadLoader : IReadLoader
    {

        List<Topic> IReadLoader.Reads(SubjectEnum subjectEnum, Student student)
        {
            List<Topic> lis = new List<Topic>();

            //获取题目
            string problems = "";
            string type = "";
            if (subjectEnum == SubjectEnum.Net)
            {
                problems = Properties.Resources.Net试题;
                type = "Net";
            }
            else if (subjectEnum == SubjectEnum.Java)
            {
                problems = Properties.Resources.Java试题;
                type = "Java";
            }

            string regex = @"<problems>(.*?)</problems>";

            var matchs = Regex.Matches(problems, regex);
            foreach (Match m in matchs)
            {
                string pro = m.Value.Replace("<problems>", "").Replace("</problems>", "").Trim();

                if (!string.IsNullOrEmpty(pro))
                {
                    lis.Add(new Topic()
                    {
                        Problem = pro,
                        AnSwer = "",
                    });
                }

            }

            //获取学生作答情况
            if (student != null && !string.IsNullOrEmpty(student.StudentID))
            {
                lis = lis.DeSerializableObject($@"{type}_{student.StudentID}_{student.Name}_{AppSetting.ComputerInfo}");
            }


            return lis;
        }

    }
}
