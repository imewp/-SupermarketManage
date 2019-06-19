using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SellGoodsInfo
    {
        string sellID;
        string kcID;
        string goodsID;
        string goodsName;
        string employeeID;
        int sellGoodsNum;
        int sellGoodsTime;
        string sellPrice;
        string sellNeedPay;
        string sellHasPay;
        string sellRemark;
        int sellFlag;

        public string SellID
        {
            get { return sellID;}
            set { sellID = value;}
        }
        public string KcID
        {
            get { return kcID;}
            set { kcID = value;}
        }
        public string GoodsID
        {
            get { return goodsID;}
            set { goodsID = value;}
        }
        public string GoodsName
        {
            get { return goodsName;}
            set { goodsName = value;}
        }
         public string EmployeeID
            {
                get { return employeeID;}
                set { employeeID = value;}
            }
        public int SellGoodsNum
         {
             get { return sellGoodsNum;}
             set { sellGoodsNum = value; } 
         }
        public int SellGoodsTime
        {
            get { return sellGoodsTime; }
            set { sellGoodsTime = value; }
        }
        public string SellPrice
        {
            get { return sellPrice;}
            set { sellPrice = value;}
        }
        public string SellNeedPay
        {
            get { return sellNeedPay;}
            set { sellNeedPay = value;}
        }
        public string SellHasPay
        {
            get { return sellHasPay;}
            set { sellHasPay = value;}
        }
        public string SellRemark
        {
            get { return sellRemark;}
            set { sellRemark = value; }
        }
        public int SellFlag
        {
            get { return sellFlag;}
            set { sellFlag = value;}
        }
    }  
}
