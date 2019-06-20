using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SellGoodsInfo
    {
        string sellID;
        string goodsID;
        string employeeID;
        string companyName;
        string depotName;
        string goodsName;
        int sellGoodsNum;
        DateTime sellGoodsTime;
        string sellGoodsPrice;
        string sellNeedPay;
        string sellHasPay;
        string sellRemark;
        int flag;

        public string SellID
        {
            get { return sellID;}
            set { sellID = value;}
        }
        public string GoodsID
        {
            get { return goodsID; }
            set { goodsID = value; }
        }
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string DepotName
        {
            get { return depotName; }
            set { depotName = value; }
        }
        public string GoodsName
        {
            get { return goodsName;}
            set { goodsName = value;}
        }
        public int SellGoodsNum
         {
             get { return sellGoodsNum;}
             set { sellGoodsNum = value; } 
         }
        public DateTime SellGoodsTime
        {
            get { return sellGoodsTime; }
            set { sellGoodsTime = value; }
        }
        public string SellGoodsPrice
        {
            get { return sellGoodsPrice; }
            set { sellGoodsPrice = value; }
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
        public int Flag
        {
            get { return flag;}
            set { flag = value; }
        }
    }  
}
