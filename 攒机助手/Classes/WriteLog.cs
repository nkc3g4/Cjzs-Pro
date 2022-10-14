using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 攒机助手专业版
{
    public static class Log
    {
        private readonly static string logPath = Form1.userpath + "\\logs\\";
        /// <summary>
        /// 写入日志，覆盖原有文件
        /// </summary>
        /// <param name="LogName">日志文件名</param>
        /// <param name="WriteInfo">日志内容</param>
        public static void WriteLog(string LogName, string WriteInfo)
        {
            if (!Directory.Exists(logPath)) { Directory.CreateDirectory(logPath); }
            if (File.Exists(logPath + LogName)) { File.Delete(logPath + LogName); }
            using (FileStream fs0 = new FileStream(logPath + LogName, FileMode.Create, FileAccess.Write))
            {
                fs0.SetLength(0);
                using (StreamWriter sw0 = new StreamWriter(fs0, Encoding.Default))
                {
                    string ws0 = string.Empty;
                    try
                    {
                        ws0 = Application.ProductName + Application.ProductVersion;
                        sw0.WriteLine(ws0);
                        ws0 = System.DateTime.Now.ToString();
                        sw0.WriteLine(ws0);
                        ws0 = WriteInfo;
                        sw0.WriteLine(ws0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("日志保存出现严重错误！\n" + ex.ToString());
                    }
                }
            }
            //sw0.Close();
        }
        /// <summary>
        /// 打开日志文件
        /// </summary>
        /// <param name="logFileName"></param>
        public static void OpenLogFile(string logFileName)
        {
            Process.Start(logPath + logFileName);
        }
    }
}