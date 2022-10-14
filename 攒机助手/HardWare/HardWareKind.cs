using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 攒机助手专业版
{
    public class HardWareKind
    {
        public override string ToString()
        {
            return this.KindNameCh;
        }
        /// <summary>
        /// 硬件类型类
        /// </summary>
        /// <param name="ChName">中文名</param>
        /// <param name="ShortName">大写英文缩写名</param>
        /// <param name="cbb">绑定ComboBox对象</param>
        /// <param name="txtName">绑定显示名称的TextBox</param>
        /// <param name="txtPrice">绑定显示价格的TextBox</param>
        public HardWareKind(string ChName, string ShortName, ComboBox cbb, TextBox txtName, TextBox txtPrice, TextBox txtFilter)
        {
            this.kindNameCh = ChName;
            this.KindNameShort = ShortName;
            this.cbb = cbb;
            this.txtName = txtName;
            this.txtPrice = txtPrice;
            this.cbb.DataSource = ComboBoxItemsArr;
            this.txtFilter = txtFilter;
        }
        public HardWareKind()
        {

        }
        private CheckBox checkLeft;

        public CheckBox CheckLeft
        {
            get { return checkLeft; }
            set { checkLeft = value; }
        }

        private CheckBox checkGift;

        public CheckBox CheckGift
        {
            get { return checkGift; }
            set { checkGift = value; }
        }

        private string kindNameCh;

        public string KindNameCh
        {
            get { return kindNameCh; }
            set { kindNameCh = value; }
        }

        private string kingNameShort;

        public string KindNameShort
        {
            get { return kingNameShort; }
            set { kingNameShort = value; }
        }
        private List<HardWare> hw = new List<HardWare>(500);

        public List<HardWare> HW
        {
            get { return hw; }
            set { hw = value; }
        }

        private ComboBox cbb;

        public ComboBox CBB
        {
            get { return cbb; }
            set { cbb = value; }
        }

        private TextBox txtName;

        public TextBox TxtName
        {
            get { return txtName; }
            set { txtName = value; }
        }
        private TextBox txtPrice;

        public TextBox TxtPrice
        {
            get { return txtPrice; }
            set { txtPrice = value; }
        }

        private TextBox txtFilter;

        public TextBox TxtFilter
        {
            get { return txtFilter; }
            set { txtFilter = value; }
        }
        private HardWare hwChoice;

        public HardWare HWChoice
        {
            get { return hwChoice; }
            set { hwChoice = value; }
        }
        public string HWFilter
        {
            get { return TxtFilter.Text.Trim(); }
        }
        private List<HardWare> comboBoxItemsArr = new List<HardWare>();

        public List<HardWare> ComboBoxItemsArr
        {
            get { return comboBoxItemsArr; }
            set { comboBoxItemsArr = value; }
        }
        public int Count
        {
            get
            {
                return hw.Count;
            }
        }
        private CuanJiPofileStruct cuanJiPofile;

        public CuanJiPofileStruct CuanJiPofile
        {
            get { return cuanJiPofile; }
            set { cuanJiPofile = value; }
        }


        private Action autoCuanJiInForm1;

        public Action AutoCuanJiInForm1
        {
            get { return autoCuanJiInForm1; }
            set { autoCuanJiInForm1 = value; }
        }



        public void AddToComboBox()
        {

            CBB.DataSource = null;

            CBB.DataSource = this.HW;

            this.CBB.SelectedIndex = 0;

            //AddToComboBox(this.HW);
        }
        private void AddToComboBox(List<HardWare> list)
        {
            CBB.DataSource = null;
            comboBoxItemsArr.Clear();
            comboBoxItemsArr.AddRange(list);
            CBB.DataSource = comboBoxItemsArr;
            this.CBB.SelectedIndex = 0;
        }
        public void ShowHardWareToTextBox()
        {
            if (this.HWChoice != null)
            {
                this.txtName.Text = Regex.Replace(HWChoice.Name, @"\([^\(]*\)", "");
                if (this.CheckGift.Checked) { this.txtPrice.Text = "赠品"; }
                else { this.txtPrice.Text = " ￥" + hwChoice.SellPrice.ToString(); }
            }
            else
            {
                this.txtName.Text = string.Empty;
                this.txtPrice.Text = string.Empty;
            }
        }
        public void AutoChooseHardWare(Func<HardWare> func)
        {
            HardWare choice;
            if (this.cbb.SelectedIndex != 0)
            {
                choice = this.cbb.SelectedItem as HardWare;
            }
            else
            {
                choice = func();
            }
            if (choice == null)
            {
                this.HWChoice = NoResult;

            }
            else
            {
                this.HWChoice = choice;
            }
        }
        public void AutoChooseHardWare(HardWare choice)
        {
            if (this.cbb.SelectedIndex != 0)
            {
                choice = this.cbb.SelectedItem as HardWare;
            }
            if (choice == null)
            {
                this.HWChoice = NoResult;
                //MessageBox.Show("Test");
            }
            else
            {
                this.HWChoice = choice;
            }
        }
        public void CJViaPofile(int money, params Regex[] rgs)
        {

            this.AutoChooseHardWare(() =>
            {
                HardWare choice = null;
                int price1 = 0;
                int price2 = 0;
                int price3 = 0;
                int price4 = 0;
                if (this.CuanJiPofile.K1 < 1) { price1 = (int)(this.CuanJiPofile.K1 * money); } else { price1 = (int)this.CuanJiPofile.K1; }
                if (this.CuanJiPofile.K2 < 1) { price2 = (int)(this.CuanJiPofile.K2 * money); } else { price2 = (int)this.CuanJiPofile.K2; }
                if (this.CuanJiPofile.K3 < 1) { price3 = (int)(this.CuanJiPofile.K3 * money); } else { price3 = (int)this.CuanJiPofile.K3; }
                if (this.CuanJiPofile.K4 < 1) { price4 = (int)(this.CuanJiPofile.K4 * money); } else { price4 = (int)this.CuanJiPofile.K4; }
                AutoHW.AutoChooseParameters paras = new AutoHW.AutoChooseParameters();
                paras.hwk = this;
                if (money < price1)
                {

                    paras.paidMoney = price1;
                    if (!string.IsNullOrEmpty(this.CuanJiPofile.RG1))
                    {
                        paras.regexes = new List<Regex>() { new Regex(this.CuanJiPofile.RG1) };
                    }
                    if (rgs != null)
                    {
                        if (paras.regexes == null)
                        {
                            paras.regexes = new List<Regex>();
                        }

                        for (int i = 0; i < rgs.Length; i++)
                        {
                            paras.regexes.Add(rgs[i]);
                        }
                    }
                    //choice = Closest.custom_cauto(NameArray, PriceArray, price1, cjp.RG1, hwsr);
                }
                else if (money >= price1 && money <= price2)
                {

                    paras.paidMoney = price2;
                    if (!string.IsNullOrEmpty(this.CuanJiPofile.RG2))
                    {
                        paras.regexes = new List<Regex>() { new Regex(this.CuanJiPofile.RG2) };
                    }
                    if (rgs != null)
                    {
                        if (paras.regexes == null)
                        {
                            paras.regexes = new List<Regex>();
                        }

                        for (int i = 0; i < rgs.Length; i++)
                        {
                            paras.regexes.Add(rgs[i]);
                        }
                    }
                    //choice = Closest.custom_cauto(NameArray, PriceArray, price2, cjp.RG2, hwsr); 
                }
                else if (money >= price2 && money <= price3)
                {

                    paras.paidMoney = price3;
                    if (!string.IsNullOrEmpty(this.CuanJiPofile.RG3))
                    {
                        paras.regexes = new List<Regex>() { new Regex(this.CuanJiPofile.RG3) };
                    }
                    if (rgs != null)
                    {
                                            if (paras.regexes == null)
                        {
                            paras.regexes = new List<Regex>();
                        }

                        for (int i = 0; i < rgs.Length; i++)
                        {
                            paras.regexes.Add(rgs[i]);
                        }
                    }

                    //choice = Closest.custom_cauto(NameArray, PriceArray, price3, cjp.RG3, hwsr); 
                }
                else if (money >= price3)
                {

                    paras.paidMoney = price4;
                    if (!string.IsNullOrEmpty(this.CuanJiPofile.RG4))
                    {
                        paras.regexes = new List<Regex>() { new Regex(this.CuanJiPofile.RG4) };
                    }
                    if (rgs != null)
                    {
                        if (paras.regexes == null)
                        {
                            paras.regexes = new List<Regex>();
                        }
                        for (int i = 0; i < rgs.Length; i++)
                        {
                            paras.regexes.Add(rgs[i]);
                        }
                    }

                    //choice = Closest.cauto(NameArray, PriceArray, price4, cjp.RG4, hwsr);
                }
                choice = AutoHW.AutoChooseHW(paras);
                return choice;

            });
            //HardWare choice = null;
            //if (this.CBB.SelectedIndex != 0)
            //{
            //    this.hwChoice = this.CBB.SelectedItem as HardWare;
            //}
            //else
            //{

            //    //if (realmoney < cjp.P1) { choice = Closest.custom_cauto(NameArray, PriceArray, price1, cjp.RG1, hwsr); }
            //    //else if (realmoney >= cjp.P1 && realmoney <= cjp.P2) { choice = Closest.custom_cauto(NameArray, PriceArray, price2, cjp.RG2, hwsr); }
            //    //else if (realmoney >= cjp.P2 && realmoney <= cjp.P3) { choice = Closest.custom_cauto(NameArray, PriceArray, price3, cjp.RG3, hwsr); }
            //    //else if (realmoney >= cjp.P3) { choice = Closest.cauto(NameArray, PriceArray, price4, cjp.RG4, hwsr); }
            //}
            //if (choice == null)
            //{
            //    hwk.HWChoice = HardWareKind.NoResult;
            //}
            //else
            //{
            //    hwk.HWChoice = choice;
            //}
        }
        public bool IsNullOrNoResult()
        {
            return this.HWChoice == null || this.hwChoice == NoResult;
        }

        public static readonly HardWare NoResult = new HardWare("没有符合要求的配件", 0, 0, 0);


    }
    public struct CuanJiPofileStruct
    {
        public int P1;
        public int P2;
        public int P3;
        public int P4;
        public float K1;
        public float K2;
        public float K3;
        public float K4;
        public string RG1;
        public string RG2;
        public string RG3;
        public string RG4;
    }
}

