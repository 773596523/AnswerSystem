using AnswerSystem.Helper;
using AnswerSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnswerSystem
{
    public class AppSetting
    {

        public static void AppIni()
        {
            InI.filePath = InIPath;
            if (string.IsNullOrEmpty(InI.ReadValue("app", "svr")))
                InI.Writue("app", "svr", "");
        }

        public static string path { get; set; } = Application.StartupPath;

        public static Student Student { get; set; } = new Student();

        public static frmHome FrmHome { get; set; }

        public static string InIPath { get; set; } = Application.StartupPath + "\\IVYTALK.ini";

        private static string svr;
        public static string Svr
        {
            get
            {
                if (string.IsNullOrEmpty(svr))
                {
                    svr = InI.ReadValue("app", "svr");
                }
                return svr;
            }
            set
            {
                svr = value;
            }
        }

        private static string computerInfo;
        public static string ComputerInfo
        {
            get
            {
                if (string.IsNullOrEmpty(computerInfo))
                {
                    computerInfo = Helper.ComputerInfo.GetInfo();
                }
                return computerInfo;
            }
        }

    }
}
