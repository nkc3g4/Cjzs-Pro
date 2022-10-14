using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;
namespace 攒机助手专业版
{
    public static class MachineCode
    {
        ///   <summary>   
        ///   获取cpu序列号       
        ///   </summary>   
        ///   <returns> string </returns>   
        public static string GetCpuInfo()
        {
            string cpuInfo = " ";
            using (ManagementClass cimobject = new ManagementClass("Win32_Processor"))
            {
                ManagementObjectCollection moc = cimobject.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                    mo.Dispose();
                }
            }
            return cpuInfo.ToString();
        }

        ///   <summary>   
        ///   获取硬盘ID       
        ///   </summary>   
        ///   <returns> string </returns>   
        public static string GetHDid()
        {
            string HDid = " ";
            using (ManagementClass cimobject1 = new ManagementClass("Win32_DiskDrive"))
            {
                ManagementObjectCollection moc1 = cimobject1.GetInstances();
                foreach (ManagementObject mo in moc1)
                {
                    HDid = (string)mo.Properties["Model"].Value;
                    mo.Dispose();
                }
            }
            return HDid.ToString();
        }

        ///   <summary>   
        ///   获取网卡硬件地址   
        ///   </summary>   
        ///   <returns> string </returns>   
        public static string GetMoAddress()
        {
            string MoAddress = " ";
            using (ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                ManagementObjectCollection moc2 = mc.GetInstances();
                foreach (ManagementObject mo in moc2)
                {
                    if ((bool)mo["IPEnabled"] == true)
                        MoAddress = mo["MacAddress"].ToString();
                    mo.Dispose();
                }
            }
            return MoAddress.ToString();
        }
        /// <summary>
        /// 获取机器码
        /// </summary>
        /// <returns>机器码</returns>
        public static string GetMachineCode()
        {
            string Macode = GetCpuInfo() + GetHDid() + GetMoAddress();

            SHA1 sha1 = new SHA1CryptoServiceProvider();

            byte[] result = Encoding.Default.GetBytes(Macode);
            byte[] output = sha1.ComputeHash(result);//tbPass为输入密码的文本框
            Macode = BitConverter.ToString(output).Replace("-", "");
            if (Macode == "")
            {
                return "出错！";
            }
            else
            {
                return Macode;
            }
        }
    }

}