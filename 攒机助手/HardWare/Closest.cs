using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace 攒机助手专业版
{
    class Closest
    {
        public static int closest(int[] finds, long Budget)
        {
            int lastestreturn = 0;
            long minsubtraction = 500000;
            long subtraction = 0;
            int i = 0;
            foreach (long pri in finds)
            {

                i++;
                if (pri == 0) { continue; }
                subtraction = Math.Abs(pri - Budget);
                //MessageBox.Show(subtraction.ToString()+"   "+minsubtraction );
                // MessageBox.Show(subtraction.ToString());
                if (subtraction < minsubtraction)
                {
                    minsubtraction = subtraction;
                    lastestreturn = i;
                    //MessageBox.Show(i.ToString ());
                }
                //List<long> items = new List<long>();
                //items.Add(subtraction);
                //MessageBox.Show(pri.ToString ());
            }
            //MessageBox.Show(lastestreturn.ToString());
            return lastestreturn - 1;
        }


        public static int cauto(string[] soc, int[] soc1, long paid, string includepart1, string zhengze)
        {
            int lastestreturn = 0;
            long minsubtraction = 100000;
            long subtraction = 0;
            int i = 0;
            foreach (long pri in soc1)
            {

                i++;
                if (pri == 0) { continue; }

                if (soc[i - 1] != null && soc[i - 1].Contains(includepart1))
                {
                    if (zhengze != null)
                    {
                        Regex r = new Regex(zhengze); // 定义一个Regex对象实例

                        Match m = r.Match(soc[i - 1]); // 在字符串中匹配

                        if (m.Success)
                        {
                            subtraction = Math.Abs(pri - paid);

                            if (subtraction < minsubtraction)
                            {
                                minsubtraction = subtraction;
                                lastestreturn = i;

                            }
                        }
                    }
                    else
                    {
                        subtraction = Math.Abs(pri - paid);

                        if (subtraction < minsubtraction)
                        {
                            minsubtraction = subtraction;
                            lastestreturn = i;

                        }

                    }
                }

            }

            return lastestreturn - 1;

        }
        public static int cauto(string[] soc, int[] soc1, long paid, string includepart1, string zhengze, string notincludepart)
        {

            int lastestreturn = 0;
            long minsubtraction = 100000;
            long subtraction = 0;
            int i = 0;
            foreach (long pri in soc1)
            {

                i++;
                if (pri == 0) { continue; }

                if (soc[i - 1] != null && soc[i - 1].Contains(includepart1) && !soc[i - 1].Contains(notincludepart))
                {
                    Regex r = new Regex(zhengze); // 定义一个Regex对象实例

                    Match m = r.Match(soc[i - 1]); // 在字符串中匹配

                    if (m.Success)
                    {
                        subtraction = Math.Abs(pri - paid);

                        if (subtraction < minsubtraction)
                        {
                            minsubtraction = subtraction;
                            lastestreturn = i;

                        }
                    }
                }

            }

            return lastestreturn - 1;
        }
        public static int cauto(string[] soc, int[] soc1, long paid, string zhengze)
        {

            int lastestreturn = 0;
            long minsubtraction = 100000;
            long subtraction = 0;
            int i = 0;
            foreach (long pri in soc1)
            {



                i++;
                if (pri == 0) { continue; }
                Regex r = new Regex(zhengze); // 定义一个Regex对象实例
                if (soc[i - 1] != null)
                {
                    Match m = r.Match(soc[i - 1]); // 在字符串中匹配
                    if (m.Success)
                    {
                        subtraction = Math.Abs(pri - paid);

                        if (subtraction < minsubtraction)
                        {
                            minsubtraction = subtraction;
                            lastestreturn = i;

                        }
                    }
                }

            }

            return lastestreturn - 1;
        }
        public static int cauto(string[] soc, int[] soc1, long paid, ArrayList includepart, ArrayList notincludepart, string zhengze)
        {

            int lastestreturn = 0;
            long minsubtraction = 0;
            long subtraction = 0;
            int i = -1;
            int choicenum = 0;//所有条件符合的第几个硬件
            foreach (long pri in soc1)
            {
                bool isgood = true;
                i++;
                if (pri == 0) { continue; }
                foreach (string hwnamerequire in includepart)
                {
                    if (!soc[i].Contains(hwnamerequire)) { isgood = false; break; }
                }
                if (!isgood) { continue; }
                foreach (string notrequire in notincludepart)
                {
                    if (soc[i].Contains(notrequire)) { isgood = false; break; }

                }
                if (!isgood) { continue; }
                Regex r = new Regex(zhengze); // 定义一个Regex对象实例
                Match m = r.Match(soc[i]); // 在字符串中匹配
                if (!m.Success) { continue; }
                choicenum++;
                subtraction = Math.Abs(pri - paid);
                if (choicenum == 1)
                {
                    minsubtraction = subtraction; lastestreturn = i;
                }
                else
                {
                    if (subtraction < minsubtraction)
                    {
                        minsubtraction = subtraction;
                        lastestreturn = i;
                    }
                }
            }
            return lastestreturn;
        }

        public static int custom_cauto(string[] soc, int[] soc1, long paid, string regex1, string regex2)
        {

            int lastestreturn = 0;
            long minsubtraction = 0;
            long subtraction = 0;
            int i = -1;
            int choicenum = 0;//所有条件符合的第几个硬件
            foreach (long pri in soc1)
            {
                i++;
                if (pri == 0) { continue; }
                Regex r = new Regex(regex1); // 定义一个Regex对象实例
                Match m = r.Match(soc[i]); // 在字符串中匹配
                Regex p = new Regex(regex2); // 定义一个Regex对象实例
                Match n = p.Match(soc[i]); // 在字符串中匹配

                if (!m.Success || !n.Success) { continue; }
                choicenum++;
                subtraction = Math.Abs(pri - paid);
                if (choicenum == 1)
                {
                    minsubtraction = subtraction; lastestreturn = i;
                }
                else
                {
                    if (subtraction < minsubtraction)
                    {
                        minsubtraction = subtraction;
                        lastestreturn = i;
                    }
                }
            }
            return lastestreturn;
        }

    }
}
