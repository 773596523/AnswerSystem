using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using AnswerSystemWPF.Helper;
using AnswerSystemWPF.IBLL;
using NPOI.XWPF.UserModel;

namespace AnswerSystemWPF.Body
{
    [Serializable]
    public class ExaminationPaper
    {
        public SubjectEnum SubjectEnum { get; set; }
        public ObservableCollection<Topic> Topics { get; set; }
        public DateTime? CompleteTime { get; set; }


        public void LoadTopics(IReadLoader rl, Student student)
        {
            if (rl == null)
                throw new Exception("IReadLoader not found");

            if (student == null || string.IsNullOrEmpty(student.StudentID))
            {
                throw new Exception("学生信息为空");
            }

            Topics = rl.Reads(SubjectEnum, student);
        }
        public void SaveTopics(Student student)
        {
            Task task = new Task(new Action(() =>
             {
                 if (student == null || string.IsNullOrEmpty(student.StudentID))
                 {
                     throw new Exception("学生信息为空");
                 }

                 Topics.SerializableObject(GetFIleName(student));
                 SaveTopicsToWord(student);
             }));
            task.Start();
        }
        public void SaveTopicsToWord(Student student)
        {
            string resultpath = AppSetting.path + @"\StudentResult";
            if (!Directory.Exists(resultpath))
            {
                Directory.CreateDirectory(resultpath);
            }

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
                r1.SetText($"学号:{student.StudentID} 姓名:{student.Name} 机器码:{AppSetting.ComputerInfo}");
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

            using (FileStream sw = File.Create(resultpath + GetFIleName(student) + ".docx"))
            {
                doc.Write(sw);
            }
            doc.Close();
        }

        public string GetFIleName(Student student)
        {
            string studentpath = "";
            switch (SubjectEnum)
            {
                case SubjectEnum.Net:
                    studentpath = $@"\Net_{student.StudentID}_{student.Name}_{AppSetting.ComputerInfo}";
                    break;
                case SubjectEnum.Java:
                    studentpath = $@"\Java_{student.StudentID}_{student.Name}_{AppSetting.ComputerInfo}";
                    break;
            }
            return studentpath;
        }
        public string GetFileData(Student student)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"学号：{student.StudentID} 姓名：{student.Name} 机器码：{AppSetting.ComputerInfo}");
            sb.AppendLine();
            foreach (var t in Topics)
            {
                sb.AppendLine($"<problems>{t.Problem}</problems>");
                sb.AppendLine($"<AnSwer>{t.AnSwer}</AnSwer>");
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public string GetInfo(Student student)
        {
            return $"学号:{student.StudentID} 姓名:{student.Name} 机器码:{AppSetting.ComputerInfo}";
        }

        public bool ExamNullTopic()
        {
            bool flag = Topics.FirstOrDefault(t => string.IsNullOrEmpty(t.AnSwer.Trim())) != null;
            return flag;
        }

    }
}
