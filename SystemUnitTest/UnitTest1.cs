using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnswerSystem;
using AnswerSystem.Model;
using AnswerSystem.IBLL;
using AnswerSystem.BLL;

namespace SystemUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IReadLoader read = new TxtReadLoader();
            AppSetting.path = @"D:\nm_C#\source\AnswerSystem\AnswerSystem\Lib\";

            ExaminationPaper examinationPaper = new ExaminationPaper
            {
                Student = new Student()
                {
                    StudentID = "20191005123",
                    Name = "小明",
                },
                SubjectEnum = SubjectEnum.Net
            };

            examinationPaper.LoadTopics(read);
            Console.WriteLine(examinationPaper.Topics.Count);

            int index = 0;
            foreach (var t in examinationPaper.Topics)
            {
                t.AnSwer = "答案" + index;
                index++;
            }

            examinationPaper.SaveTopics();
        }


    }
}
