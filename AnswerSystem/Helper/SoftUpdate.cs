using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AnswerSystem.Helper
{
    /// <summary>
    /// 软件安全验证
    /// </summary>
    public class SoftUpdate
    {
        private SoftUpdate() { }
        public static SoftUpdate soft_update = new SoftUpdate();

        /// <summary>
        /// 更新
        /// </summary>
        public static void Upadte()
        {
            IvyHelper.F_0001_0010();
        }

        /// <summary>
        /// 验证软件
        /// </summary>
        public static int VerifySoft()
        {
            try
            {
                return IvyHelper.Exists();
            }
            catch (Exception ex)
            {
                LogHelper.writeLog(ex);
                throw;
            }
        }

    }

    public class IvyHelper
    {

        public static int Encrypt(string str, out string str2)
        {
            try
            {
                StringBuilder ls_source = new StringBuilder(str);
                StringBuilder ls_enc = new StringBuilder((ls_source.Length / 128 + 1) * 256 + 1);
                int flag = F_0001_0022(ls_source, ls_enc);

                str2 = ls_enc.ToString();

                return flag;
            }
            catch (Exception ex)
            {
                LogHelper.writeLog(ex);
                throw;
            }
        }
        public static int Decode(string str, out string str2)
        {
            try
            {
                StringBuilder ls_enc = new StringBuilder(str);
                StringBuilder ls_dec = new StringBuilder(ls_enc.Length);
                int flag = F_0001_0048(ls_enc, ls_dec);

                str2 = ls_dec.ToString();

                return flag;
            }
            catch (Exception ex)
            {
                LogHelper.writeLog(ex);
                throw;
            }
        }

        public static int Exists()
        {
            try
            {
                return 1;
                ///   return F_0001_0049(); //1有狗  
            }
            catch (Exception ex)
            {
                LogHelper.writeLog(ex);
                return 0;
            }
        }


        [DllImport("IVYGetValue.dll")]
        public static extern int F_0001_0010();
        [DllImport("IVYGetValue.dll")]
        static extern int F_0001_0022(StringBuilder as_from, StringBuilder as_to);
        [DllImport("IVYGetValue.dll")]
        static extern int F_0001_0048(StringBuilder as_from, StringBuilder as_to);
        [DllImport("IVYGetValue.dll")]
        static extern int F_0001_0049();

    }
}
