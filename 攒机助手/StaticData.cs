using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 攒机助手专业版
{
    class SData
    {
        public static HardWareKind hwCpu;
        public static HardWareKind hwACpu;
        public static HardWareKind hwMb;
        public static HardWareKind hwRam;
        public static HardWareKind hwHdd;
        public static HardWareKind hwSsd;
        public static HardWareKind hwGpu;
        public static HardWareKind hwLcd;
        public static HardWareKind hwBox;
        public static HardWareKind hwFan;
        public static HardWareKind hwPower;
        public static HardWareKind hwCdrom;
        public static HardWareKind hwKb;
        public static HardWareKind hwHs;
        public static HardWareKind hwSp;
        public static HardWareKind hwO;
        public static HardWareKind hwMou;
        public static HardWareKind hwCam;
        ////       if (!(MainDt.Rows[i][1].ToString().Contains("H61") || Mai
        //nDt.Rows[i][1].ToString().Contains("H67") || MainDt.Rows
        //    [i][1].ToString().Contains("Z68") || MainDt.Rows[i][1].ToString().C
        //        ontains("P67") || MainDt.Rows[i][1].ToString().Contains("H71") || MainDt
        //            .Rows[i][1].ToString().Contains("H77") || MainDt.Rows[i][1].ToS
        //                tring().Contains("B75") || MainDt.Rows[i][1].ToString().Conta
        //                    ins("Z77") || MainDt.Rows[i][1].ToString().Contains("X79") || 
        //MainDt.Rows[i][1].ToString().Contains("H81") || MainDt.Rows[i][1].ToString().Co
        //    ntains("H85") || MainDt.Rows[i][1].ToString().Contains("H87") || MainDt.Rows[i][
        //1].ToString().Contains("B85") || MainDt.Rows[i][1].ToString().Contains("Z87") || M
        //    ainDt.Rows[i][1].ToString().Contains("AM3") || MainDt.Rows[i][1].ToString().Cont
        //        ains("FM1") || MainDt.Rows[i][1].ToString().Contains("FM2") || MainDt.Rows[i][1].ToS
        //            tring().Contains("Z97") || MainDt.Rows[i][1].ToString().Contains("H97")))
        public static List<string> IntelChipest = new List<string>() 
        {
            "H61",
            "H67",
            "Z68",
            "P67",
            "H71",
            "H77",
            "B75",
            "Z77",
            "X79",
            "H81",
            "H85",
            "H87",
            "B85",
            "Z87",
            "Z97",
            "H97",
            "X99",
            "H110",
            "B150",
            "H170",
            "Z170"
        };
        public static List<string> AMDSocket = new List<string>() 
        {
            "AM3",
            "FM1",
            "FM2",
            "AM3+",
            "FM2+"
        };
        // if (!(MainDt.Rows[i][1].ToString().Contains("i3") || MainDt.Rows[i][1].ToString().Contains("i5") || MainDt.Rows[i][1].ToString().Contains("i7") || 
        //MainDt.Rows[i][1].ToString().Contains("E3") || MainDt.Rows[i][1].ToString().Contains("奔腾") || 
        //MainDt.Rows[i][1].ToString().Contains("赛扬") || MainDt.Rows[i][1].ToString().Contains("FX") ||
        //MainDt.Rows[i][1].ToString().Contains("A4") || MainDt.Rows[i][1].ToString().Contains("A6") || 
        ////MainDt.Rows[i][1].ToString().Contains("A8") || MainDt.Rows[i][1].ToString().Contains("A10") ||
        //MainDt.Rows[i][1].ToString().Contains("速龙") || MainDt.Rows[i][1].ToString().Contains("羿龙")))
        public static List<string> IntelCpuSeries = new List<string>()
        {
            "i3",
            "i5",
            "i7",
            "E3",
            "奔腾",
            "赛扬"
        };
        public static List<string> AMDCpuSeries = new List<string>()
        {
            "FX",
            "A4",
            "A6",
            "A8",
            "A10",
            "速龙",
            "羿龙"
        };
        public static List<HardWareKind> allHwKind = new List<HardWareKind>();
    }
}
