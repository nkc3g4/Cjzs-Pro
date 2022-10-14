using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace 攒机助手专业版
{
    public class AutoHW
    {
        public struct AutoChooseParameters
        {
            public HardWareKind hwk;
            public int paidMoney;
            public IList<string> includedPart;
            public IList<string> notIncludedPart;
            public IList<Regex> regexes;
            public Func<string, bool> func;
        }

        /// <summary>
        /// 返回符合要求的硬件
        /// </summary>
        /// <param name="hwk">硬件种类对象</param>
        /// <param name="paidMoney">预算</param>
        /// <param name="includedPart">包含部分</param>
        /// <param name="notIncludedPart">不包含部分</param>
        /// <param name="regex">正则表达式</param>
        /// <returns></returns>
        public static HardWare AutoChooseHW(AutoChooseParameters paras)
        {
            if (paras.hwk == null || paras.hwk.HW == null) return null;
            //if (paras.hwk.HW == null) return null;
            else
            {
                int choicenum = 0;//所有条件符合的第几个硬件
                int minsubtraction = 0;
                HardWare lastestReturn = null;
                int subtraction = 0;

                //Regex r = new Regex(regex);
                foreach (var item in paras.hwk.HW)
                {
                    if (item.SellPrice == 0) continue;
                    bool isgood = true;
                    if (paras.includedPart != null)
                    {
                        foreach (var includedItem in paras.includedPart)
                        {
                            if (!item.Name.Contains(includedItem)) { isgood = false; break; }
                        }
                        //paras.includedPart = new List<string>();
                    }
                    //paras.includedPart.Add(paras.hwk.TxtFilter.Text.Trim());


                    if (paras.notIncludedPart != null)
                    {
                        foreach (var notIncludedItem in paras.notIncludedPart)
                        {
                            if (item.Name.Contains(notIncludedItem)) { isgood = false; break; }
                        }
                    }

                    if (paras.regexes == null)
                    {
                        paras.regexes = new List<Regex>();
                    }

                    paras.regexes.Add(new Regex(paras.hwk.TxtFilter.Text.Trim()));
                    if (paras.regexes != null)
                    {
                        foreach (var regexItem in paras.regexes)
                        {
                            if (!regexItem.IsMatch(item.Name)) { isgood = false; break; }
                        }
                    }
                    if (paras.func != null)
                    {
                        if (!paras.func(item.Name)) { isgood = false; }
                    }
                    if (!isgood) { continue; }

                    choicenum++;

                    subtraction = Math.Abs(item.SellPrice - paras.paidMoney);
                    if (choicenum == 1)
                    {
                        minsubtraction = subtraction;
                        lastestReturn = item;
                    }

                    else
                    {
                        if (subtraction < minsubtraction)
                        {
                            minsubtraction = subtraction;
                            lastestReturn = item;
                        }

                    }
                }
                return lastestReturn;
            }
        }


    }
}
