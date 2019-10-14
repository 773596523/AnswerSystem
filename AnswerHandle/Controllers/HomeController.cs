using AnswerHandle.Helper;
using AnswerHandle.Model;
using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnswerHandle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string UploadExam()
        {
            WebHelper w = new WebHelper();

            try
            {
                string FileName = w.ObjectToString("FileName");
                string Title = w.ObjectToString("Title");
                string Info = w.ObjectToString("Info");
                List<Model.Topic> FileData = w.GetList<Model.Topic>("FileData");

                string resultpath = AppSetting.Path + @"\StudentResult";
                if (!Directory.Exists(resultpath))
                {
                    Directory.CreateDirectory(resultpath);
                }
                string studentpath = resultpath + FileName;

                XWPFDocument doc = new XWPFDocument();

                {
                    XWPFParagraph p = doc.CreateParagraph();
                    p.Alignment = ParagraphAlignment.CENTER;

                    XWPFRun r = p.CreateRun();
                    r.SetText(Title + "试题");
                    r.IsBold = true;
                    r.FontSize = 30;
                }
                {
                    XWPFParagraph p1 = doc.CreateParagraph();   //向新文档中添加段落

                    XWPFRun r1 = p1.CreateRun();                //向该段落中添加文字
                    r1.SetText(Info);
                    r1.IsBold = true;
                    XWPFParagraph p2 = doc.CreateParagraph();
                }
                {
                    int index = 1;
                    foreach (Topic t in FileData)
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

                FileStream sw = System.IO.File.Create(studentpath + ".docx");
                doc.Write(sw);
                sw.Close();

                w.WriteSuccess();
            }
            catch (Exception ex)
            {
                w.WriteError(ex);
            }

            return w.NmJson();
        }

    }
}