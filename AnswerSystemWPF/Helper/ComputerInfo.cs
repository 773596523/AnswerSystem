using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace AnswerSystemWPF.Helper
{
    public static class ComputerInfo
    {
        public static string GetProcessor()
        {
            string str = "";
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();

            try
            {
                foreach (ManagementObject mo in moc)
                {
                    object value = mo.Properties["ProcessorId"].Value;
                    if (value != null && !string.IsNullOrEmpty(value.ToString()))
                    {
                        str = value.ToString();
                        break;
                    }
                }
            }
            catch (Exception)
            {

            }
            return str;
        }

        public static string GetPhysicalMedia()
        {
            string str = "";
            var mc = new ManagementClass("Win32_PhysicalMedia");
            var moc = mc.GetInstances();
            try
            {
                foreach (ManagementObject mo in moc)
                {
                    object value = mo.Properties["SerialNumber"].Value;
                    if (value != null && !string.IsNullOrEmpty(value.ToString()))
                    {
                        str = value.ToString();
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }

            return str;
        }

        public static string GetInfo()
        {
            string str = GetProcessor() + GetPhysicalMedia();

            return MD5.ToMD5(str);
        }

    }
}
