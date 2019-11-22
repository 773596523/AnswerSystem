using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnswerSystemWPF.Body;
using AnswerSystemWPF.Helper;

namespace AnswerSystemWPF
{
    public static class AppSetting
    {

        public static void AppIni()
        {
            InI.filePath = InIPath;

            if (string.IsNullOrWhiteSpace(Svr))
                Svr = "";


        }

        public static string path { get; set; } = AppDomain.CurrentDomain.BaseDirectory;

        public static Student Student { get; set; }

        public static string InIPath { get; set; } = AppDomain.CurrentDomain.BaseDirectory + "\\IVYTALK.ini";

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
                if (svr != value)
                {
                    InI.Writue("app", "svr", value);
                }
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
