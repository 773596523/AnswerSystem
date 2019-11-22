using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AnswerSystemWPF
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            AppSetting.AppIni();

            Process thisProc = Process.GetCurrentProcess();
            if (Process.GetProcessesByName(thisProc.ProcessName).Length > 1)
            {
                MessageBox.Show("Application is already running.");
                Application.Current.Shutdown();
                return;
            }

            AppSetting.AppIni();

            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }


    }
}
