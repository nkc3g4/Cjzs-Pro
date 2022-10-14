using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Windows.Forms;
namespace 攒机助手专业版
{
    public class AuthKeyManager
    {
        public static void Ac()
        {
            string readkey = string.Empty;

            try
            {
                string sLine1 = string.Empty;
                //string authkey = "";
                string AN = string.Empty;
                using (StreamReader auth1 = new StreamReader(Form1.userpath + AESEncryption.Decrypt("QhahUnSGMeMhDHH6vfe0QQ==")))
                {
                    while (sLine1 != null)
                    {
                        //MD5 md5 = new MD5CryptoServiceProvider();
                        sLine1 = auth1.ReadLine();
                        if (sLine1 != null && sLine1.Contains(AESEncryption.Decrypt("urIFeZAmTcTbw/JVRnSwyw==")))
                        {
                            AN = sLine1.Substring(sLine1.IndexOf(AESEncryption.Decrypt("NgbBttjUwzUWvh/WYelNYw==")) + 1);
                            //MessageBox.Show(AN);
                        }
                        else if (sLine1 != null && sLine1.Contains(AESEncryption.Decrypt("3Th1/iWhLKeP6YLH8I1trw==")))
                        {
                            readkey = sLine1.Substring(sLine1.IndexOf(AESEncryption.Decrypt("NgbBttjUwzUWvh/WYelNYw==")) + 1);
                        }
                    }
                }
            }
            catch
            {
                OnlineActFailed(null);

            }

            try
            {
                string strURL = AESEncryption.Decrypt("gfyHiGjTt887ZAyXQNAg4eWmqHiU3CAB249/CsIzw4u3gmXXHrwwAxy7lX2lr2CJR6776CFYN+KuuDC5/UPCAA==") + HttpUtility.UrlEncode(AESEncryption.Encrypt(MachineCode.GetMachineCode()));
                System.Net.HttpWebRequest request;
                // 创建一个HTTP请求
                request = (HttpWebRequest)WebRequest.Create(strURL);
                //request.Method="get";
                HttpWebResponse response;
                response = (System.Net.HttpWebResponse)request.GetResponse();
                StreamReader myreader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string responseText = myreader.ReadToEnd();
                myreader.Close();
                //MessageBox.Show(AESEncryption.Decrypt(responseText));
                if (responseText != "" && AESEncryption.Decrypt(responseText).Substring(0, 1) != "1")
                {

                    string strURL2 = AESEncryption.Decrypt("gfyHiGjTt887ZAyXQNAg4UkT+fAGel4TSFqEaM5VlGXGFJtHX/tWTC7Ou5yOmd4G") + HttpUtility.UrlEncode(AESEncryption.Encrypt(MachineCode.GetMachineCode() + "|" + AN + "|" + readkey));
                    HttpWebRequest request2;
                    // 创建一个HTTP请求
                    request2 = (HttpWebRequest)WebRequest.Create(strURL2);
                    //request.Method="get";
                    HttpWebResponse response2;
                    response2 = (HttpWebResponse)request2.GetResponse();
                    StreamReader myreader2 = new System.IO.StreamReader(response2.GetResponseStream(), Encoding.UTF8);
                    string responseText2 = myreader2.ReadToEnd();
                    myreader2.Close();
                    string deres = AESEncryption.Decrypt(responseText2);
                    //MessageBox.Show(deres);
                    if (deres.Substring(deres.Length - 1, 1) == "1")
                    {

                        FileStream fs = new FileStream(Form1.userpath + AESEncryption.Decrypt("neYfSrve9QpCEhc5PBUJi10THOoXir/h3uOghc+IA3E="), FileMode.OpenOrCreate, FileAccess.Write);
                        fs.SetLength(0);
                        StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                        string writeString = responseText2;
                        sw.WriteLine(writeString);
                        sw.Close();

                    }
                    else
                    {
                        OnlineActFailed(null);
                        //Application.Exit();

                        //MessageBox.Show("注册信息验证失败\n如有疑问可联系QQ 1409231794或旺旺 姑姑叫哈哈");
                        //Environment.Exit(0);
                    }
                }
                else
                {
                    ///success
                    if (!File.Exists(Form1.userpath + AESEncryption.Decrypt("neYfSrve9QpCEhc5PBUJi10THOoXir/h3uOghc+IA3E=")))
                    {
                        using (FileStream fs = new FileStream(Form1.userpath + AESEncryption.Decrypt("neYfSrve9QpCEhc5PBUJi10THOoXir/h3uOghc+IA3E="), FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fs.SetLength(0);
                            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                            {
                                string writeString = responseText;
                                sw.WriteLine(writeString);
                            }
                            //sw.Close();
                        }
                    }

                }
            }
            catch (Exception ex1)
            {
                try
                {

                    //MessageBox.Show(ex1.ToString());
                    if (File.Exists(Form1.userpath + AESEncryption.Decrypt("neYfSrve9QpCEhc5PBUJi10THOoXir/h3uOghc+IA3E=")))
                    {
                        //MessageBox.Show(Application.StartupPath + AESEncryption.Decrypt("neYfSrve9QpCEhc5PBUJi10THOoXir/h3uOghc+IA3E="));
                        StreamReader ota = new StreamReader(Form1.userpath + AESEncryption.Decrypt("neYfSrve9QpCEhc5PBUJi10THOoXir/h3uOghc+IA3E="));
                        string sLine0 = "";
                        while (sLine0 != null)
                        {
                            sLine0 = ota.ReadLine();
                            if (sLine0 == null || sLine0 == "") continue;

                            string de = AESEncryption.Decrypt(sLine0);
                            //MessageBox.Show(AESEncryption.Decrypt(sLine0).Substring(AESEncryption.Decrypt(sLine0).Length - 1, 1));

                            if (de.Substring(de.Length - 1, 1) != "1")
                            {

                                //Application.Exit();

                                //MessageBox.Show("注册信息验证失败，请确保网络连接正常！\n如有疑问可联系QQ 1409231794或旺旺 姑姑叫哈哈");
                                //Environment.Exit(0);

                            }

                        }
                    }

                    else
                    {
                        OnlineActFailed(ex1.ToString());
                        //Application.Exit();

                        //MessageBox.Show("注册信息验证失败，请确保网络连接正常！\n如有疑问可联系QQ 1409231794或旺旺 姑姑叫哈哈\n" + ex1.ToString());
                        //Environment.Exit(0);

                    }
                }
                catch (Exception ex)
                {
                    OnlineActFailed(ex.ToString());
                    //MessageBox.Show(ex.ToString());
                    //Application.Exit();

                    //MessageBox.Show("注册信息验证失败，请确保网络连接正常！\n如有疑问可联系QQ 1409231794或旺旺 姑姑叫哈哈");
                    //Environment.Exit(0);

                }
            }
            //auth1.Close();
            //auth1.Dispose();

        }

        private static void OnlineActFailed(string msg)
        {
            if (msg != null)
            {
                Log.WriteLog("OnlineActFailed.log", msg);
            }
            //MessageBox.Show("Test");
            //CreateTrialFile();

            Application.Exit();
            MessageBox.Show("注册信息验证失败\n如有疑问可联系QQ 1409231794或旺旺 姑姑叫哈哈");
            CreateTrialFile();
            Environment.Exit(0);
        }
        public static string AN = "";
        public static string GetAuthName()
        {
            if (GetIsTrial()) { return "试用版"; }
            else { return ReadAuthFile()[1]; }
        }
        public static string[] ReadAuthFile()
        {
            bool istrial = true;
            using (StreamReader auth1 = new StreamReader(Form1.userpath + "\\auth.key"))
            {
                string sLine1 = string.Empty;
                string authkey = string.Empty;
                while (sLine1 != null)
                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    sLine1 = auth1.ReadLine();
                    try
                    {
                        if (sLine1.Contains("[EMAIL]"))
                        {
                            byte[] result;
                            if (sLine1.Substring(sLine1.IndexOf("]") + 1) == "Trial") { break; }
                            if (sLine1.Substring(sLine1.IndexOf("]") + 1).Length > 7 && sLine1.Substring(sLine1.IndexOf("]") + 1, 7) == "Single_")
                            {
                                result = Encoding.Default.GetBytes("cjzs_pro_" + sLine1.Substring(sLine1.IndexOf("]") + 1) + MachineCode.GetMachineCode());
                                AN = sLine1.Substring(sLine1.IndexOf("]") + 1);
                                //MessageBox.Show(AN);
                            }
                            else
                            {
                                result = Encoding.Default.GetBytes("cjzs_pro_" + sLine1.Substring(sLine1.IndexOf("]") + 1));
                                AN = sLine1.Substring(sLine1.IndexOf("]") + 1);

                            }
                            byte[] output = md5.ComputeHash(result);//tbPass为输入密码的文本框
                            authkey = BitConverter.ToString(output).Replace("-", "");
                        }
                        else if (sLine1.Contains("[KEY]"))
                        {
                            string readkey = sLine1.Substring(sLine1.IndexOf("]") + 1);
                            if (authkey != readkey)
                            {

                                istrial = true;
                                break;
                            }
                            else
                            {
                                istrial = false;
                                break;

                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        Application.Exit();

                        MessageBox.Show("程序出错！请联系QQ 1409231794\n" + ex.ToString());
                    }

                    //return "";
                }
            }
            string kind = "100PC";
            //string name = sLine1.Substring(sLine1.IndexOf("]") + 1);

            if (AN.Contains("Single_"))
            {
                kind = "单PC";
                AN.Remove(0, 7);
            }
            if (istrial)
            {
                kind = "试用版";

            }
            string[] s = { istrial.ToString(), AN, kind };//简单定义一个数组
            return s;//返回数组

            //return istrial;
        }
        public static bool GetIsTrial()
        {
            if (!File.Exists(Form1.userpath + "\\auth.key"))
            {
                CreateTrialFile();
                return false;
            }
            else
            {
                if (ReadAuthFile()[0] == "True")
                {
                    /////////////////////////////标记处，原为true
                    return false;
                }
                else
                {
                    return false;
                }

            }
        }
        public static void CreateTrialFile()
        {
            try
            {
                FileStream fs = new FileStream(Form1.userpath + "\\auth.key", FileMode.Create, FileAccess.Write);
                fs.SetLength(0);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                string writeString = "";
                writeString = "[EMAIL]Trial";
                sw.WriteLine(writeString);
                writeString = "[KEY]Trial";
                sw.WriteLine(writeString);
                sw.Close();
                sw.Dispose();
                fs.Close();
                fs.Dispose();
            }
            catch (Exception ex)
            {
                Log.WriteLog("CreateTrialFile.log", ex.ToString());
            }
        }
    }
}