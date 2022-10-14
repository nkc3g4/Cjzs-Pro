using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 攒机助手专业版
{
    static class SettingItems
    {
        //string settingsini = "";
        //private static Dictionary<string, string> settings = new Dictionary<string, string>();

        //public static Dictionary<string, string> DictSettings
        //{
        //    get { return settings; }
        //    set { settings = value; }
        //}
        public static string PrintCol1Txt { get; set; }
        public static string PrintCol2Txt { get; set; }
        public static string PrintCol3Txt { get; set; }
        public static string PrintCol4Txt { get; set; }
        public static string PrintCol5Txt { get; set; }


        public static bool ShowAd
        {
            get;
            set;
        }
        /// <summary>
        /// 自动更新
        /// </summary>
        public static bool AutoUpdate { get; set; }
        /// <summary>
        /// data.mdb路径
        /// </summary>
        public static string MdbPath { get; set; }
        /// <summary>
        /// data.mdb密码
        /// </summary>
        public static string MdbPw { get; set; }
        /// <summary>
        /// 打印模式
        /// </summary>
        public static ModeEnum PrintMode { get; set; }
        /// <summary>
        /// 保存模式
        /// </summary>
        public static ModeEnum SaveMode { get; set; }
        /// <summary>
        /// 显示问题咨询
        /// </summary>
        public static bool ShowBbs { get; set; }
        /// <summary>
        /// 利润显示
        /// </summary>
        public static CostPriceEnum CostPrice { get; set; }
        public enum ModeEnum
        {
            Doc = 0,
            Txt = 1
        }
        [Flags]
        public enum CostPriceEnum
        {
            不显示 = 0,
            成本 = 1,
            利润 = 2,
            利润率 = 3,
        }
        public static string ReadValue(string keyName)
        {
            return IniFile.ReadVal("Main", keyName, Form1.settingsIni);
        }
        public static void ReadIni()
        {
            ////IniFile.ReadVal ("Main")
            SettingItems.ShowAd = StringToBool(IniFile.ReadVal("Main", "ShowAd", Form1.settingsIni));
            SettingItems.AutoUpdate = StringToBool(IniFile.ReadVal("Main", "AutoUpdate", Form1.settingsIni));
            SettingItems.ShowBbs = StringToBool(IniFile.ReadVal("Main", "ShowBBS", Form1.settingsIni));
            SettingItems.MdbPath = IniFile.ReadVal("Main", "MdbPath", Form1.settingsIni);
            SettingItems.MdbPw = IniFile.ReadVal("Main", "MdbPw", Form1.settingsIni);
            SettingItems.PrintMode = StringToModeEnum(IniFile.ReadVal("Main", "Print", Form1.settingsIni));
            SettingItems.SaveMode = StringToModeEnum(IniFile.ReadVal("Main", "Save", Form1.settingsIni));
            SettingItems.CostPrice = StringToCostPriceEnum(IniFile.ReadVal("Main", "CostPrice", Form1.settingsIni));

            SettingItems.PrintCol1Txt = IniFile.ReadVal("Print", "Col1Txt", Form1.settingsIni);
            SettingItems.PrintCol2Txt = IniFile.ReadVal("Print", "Col2Txt", Form1.settingsIni);
            SettingItems.PrintCol3Txt = IniFile.ReadVal("Print", "Col3Txt", Form1.settingsIni);
            SettingItems.PrintCol4Txt = IniFile.ReadVal("Print", "Col4Txt", Form1.settingsIni);
            SettingItems.PrintCol5Txt = IniFile.ReadVal("Print", "Col5Txt", Form1.settingsIni);

        }
        public static void WriteIni()
        {
            //foreach (var item in DictSettings)
            //{
            //    IniFile.WriteVal("Main", item.Key, item.Value, Form1.settingsini);
            //}
            IniFile.WriteVal("Main", "ShowAd", BoolToString(SettingItems.ShowAd), Form1.settingsIni);
            IniFile.WriteVal("Main", "AutoUpdate", BoolToString(SettingItems.AutoUpdate), Form1.settingsIni);
            IniFile.WriteVal("Main", "MdbPath", SettingItems.MdbPath, Form1.settingsIni);
            IniFile.WriteVal("Main", "MdbPw", SettingItems.MdbPw, Form1.settingsIni);
            IniFile.WriteVal("Main", "Print", ModeEnumToString(SettingItems.PrintMode), Form1.settingsIni);
            IniFile.WriteVal("Main", "Save", ModeEnumToString(SettingItems.SaveMode), Form1.settingsIni);
            IniFile.WriteVal("Main", "CostPrice", CostPriceEnumToString(SettingItems.CostPrice), Form1.settingsIni);
            IniFile.WriteVal("Main", "ShowBBS", BoolToString(SettingItems.ShowBbs), Form1.settingsIni);

            IniFile.WriteVal("Print", "Col1Txt", PrintCol1Txt,Form1.settingsIni);
            IniFile.WriteVal("Print", "Col2Txt", PrintCol2Txt, Form1.settingsIni);
            IniFile.WriteVal("Print", "Col3Txt", PrintCol3Txt, Form1.settingsIni);
            IniFile.WriteVal("Print", "Col4Txt", PrintCol4Txt, Form1.settingsIni);
            IniFile.WriteVal("Print", "Col5Txt", PrintCol5Txt, Form1.settingsIni);


        }
        private static string BoolToString(bool bl)
        {
            if (bl) { return "1"; }
            else return "0";
        }
        private static bool StringToBool(string s)
        {
            if (s == "1") { return true; }
            else return false;
        }
        private static ModeEnum StringToModeEnum(string s)
        {
            if (s == "1") { return ModeEnum.Txt; }
            else return ModeEnum.Doc;
        }
        private static string ModeEnumToString(ModeEnum me)
        {
            if (me == ModeEnum.Doc) return "0";
            else return "1";
        }
        private static CostPriceEnum StringToCostPriceEnum(string s)
        {
            if (s == "0") return CostPriceEnum.不显示;
            else if (s == "2") return CostPriceEnum.利润;
            else if (s == "3") return CostPriceEnum.利润率;
            else return CostPriceEnum.成本;
        }
        private static string CostPriceEnumToString(CostPriceEnum cpe)
        {
            return ((int)cpe).ToString();
            //if (cpe == CostPriceEnum.成本) return "1";
            //else if (cpe == CostPriceEnum.利润) return "2";
            //else if (cpe == CostPriceEnum.利润率) return "3";
            //else return "0";
        }

    }
}
