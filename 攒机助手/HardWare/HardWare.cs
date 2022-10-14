using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 攒机助手专业版
{
    public class HardWare
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="sellPrice">售价</param>
        /// <param name="buyPrice">进价</param>
        /// <param name="warranty">质保</param>
        public HardWare(string name, int sellPrice, int buyPrice, int warranty)
        {
            this.SellPrice = sellPrice;
            this.BuyPrice = buyPrice;
            this.Warranty = warranty;
            this.Name = name;
        }
        public HardWare(string name, int sellPrice, int buyPrice, int warranty, int dbID)
        {
            this.SellPrice = sellPrice;
            this.BuyPrice = buyPrice;
            this.Warranty = warranty;
            this.Name = name;
            this.DBID = dbID;
        }
        public HardWare()
        {

        }
        private int buyPrice;

        public int BuyPrice
        {
            get { return buyPrice; }
            set { buyPrice = value; }
        }

        private int sellPrice;

        public int SellPrice
        {
            get { return sellPrice; }
            set { sellPrice = value; }
        }

        public int Price
        {
            get { return sellPrice; }
            set { sellPrice = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int warranty;

        public int Warranty
        {
            get { return warranty; }
            set { warranty = value; }
        }


        public override string ToString()
        {
            if (this.SellPrice == 0) return this.name;
            else
            {
                return (this.Name + CreateSpace(30 - System.Text.Encoding.Default.GetBytes(this.Name).Length) + "￥" + this.SellPrice);
                //return (this.Name + "   ￥" + this.SellPrice);
            }
        }
        private string CreateSpace(int num)
        {
            if (num > 0)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(' ', num);

                return sb.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        //private Dictionary <string,string> specifications;

        //public Dictionary <string,string> Specifications
        //{
        //    get { return specifications; }
        //    set { specifications = value; }
        //}
        private int dbId;

        public int DBID
        {
            get { return dbId; }
            set { dbId = value; }
        }

    }
}
