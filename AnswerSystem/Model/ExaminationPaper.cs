using AnswerSystem.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using AnswerSystem.Helper;
using NPOI;
using NPOI.XWPF.UserModel;

namespace AnswerSystem.Model
{
    [Serializable]
    public class ExaminationPaper
    {
        public SubjectEnum SubjectEnum { get; set; }
        public Student Student { get; set; }
        public List<Topic> Topics { get; set; }
        public DateTime? CompleteTime { get; set; }


        public void LoadTopics(IReadLoader rl)
        {
            if (rl == null)
                throw new Exception("IReadLoader not found");

            if (Student == null || string.IsNullOrEmpty(Student.StudentID))
            {
                throw new Exception("学生信息为空");
            }

            Topics = rl.Reads(SubjectEnum, Student);
        }
        public void SaveTopics()
        {
            Task task = new Task(new Action(() =>
             {
                 if (Student == null || string.IsNullOrEmpty(Student.StudentID))
                 {
                     throw new Exception("学生信息为空");
                 }

                 Topics.SerializableObject(GetFIleName());
                 SaveTopicsToWord();
             }));
            task.Start();
        }
        public void SaveTopicsToWord()
        {
            string resultpath = AppSetting.path + @"\StudentResult";
            if (!Directory.Exists(resultpath))
            {
                Directory.CreateDirectory(resultpath);
            }
            string studentpath = resultpath + GetFIleName();

            XWPFDocument doc = new XWPFDocument();

            {
                XWPFParagraph p = doc.CreateParagraph();
                p.Alignment = ParagraphAlignment.CENTER;

                XWPFRun r = p.CreateRun();
                r.SetText(SubjectEnum.ToString() + "试题");
                r.IsBold = true;
                r.FontSize = 30;
            }
            {
                XWPFParagraph p1 = doc.CreateParagraph();   //向新文档中添加段落

                XWPFRun r1 = p1.CreateRun();                //向该段落中添加文字
                r1.SetText($"学号:{Student.StudentID} 姓名:{Student.Name} 机器码:{AppSetting.ComputerInfo}");
                r1.IsBold = true;
                XWPFParagraph p2 = doc.CreateParagraph();
            }
            {
                int index = 1;
                foreach (Topic t in Topics)
                {
                    XWPFParagraph p = doc.CreateParagraph();
                    {
                        XWPFRun r = p.CreateRun();
                        r.SetText(index + "." + t.Problem);
                        r.IsBold = true;
                        r.SetColor("255,0,0");
                    }
                    XWPFParagraph p2 = doc.CreateParagraph();
                    {
                        XWPFRun r = p2.CreateRun();
                        r.SetText(t.AnSwer);
                    }
                    XWPFParagraph p3 = doc.CreateParagraph();
                    index++;
                }
            }

            FileStream sw = File.Create(resultpath + GetFIleName() + ".docx");
            doc.Write(sw);
            sw.Close();
        }

        public string GetFIleName()
        {
            string studentpath = "";
            switch (SubjectEnum)
            {
                case SubjectEnum.Net:
                    studentpath = $@"\Net_{Student.StudentID}_{Student.Name}_{AppSetting.ComputerInfo}";
                    break;
                case SubjectEnum.Java:
                    studentpath = $@"\Java_{Student.StudentID}_{Student.Name}_{AppSetting.ComputerInfo}";
                    break;
            }
            return studentpath;
        }
        public string GetFileData()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"学号：{Student.StudentID} 姓名：{Student.Name} 机器码：{AppSetting.ComputerInfo}");
            sb.AppendLine();
            foreach (var t in Topics)
            {
                sb.AppendLine($"<problems>{t.Problem}</problems>");
                sb.AppendLine($"<AnSwer>{t.AnSwer}</AnSwer>");
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public string GetInfo()
        {
            return $"学号:{Student.StudentID} 姓名:{Student.Name} 机器码:{AppSetting.ComputerInfo}";
        }

        public bool ExamNullTopic()
        {
            bool flag = false;
            if (Topics.FirstOrDefault(t => string.IsNullOrEmpty(t.AnSwer.Trim())) != null)
            {
                flag = true;
            }
            return flag;
        }

    }
}
