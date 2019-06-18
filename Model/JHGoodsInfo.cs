using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class JHGoodsInfo
    {
        string goodsID;
        string employeeID;
        string companyName;
        string depotName;
        string goodsName;
        int goodsNum;
        string goodsUnit;
        float  goodsJHPrice;
        float  goodsSellPrice;
        float  goodsNeedPay;
        float  goodsHasPay;
        string goodsRemark;
        DateTime goodsTime;
        int flag;

        public string GoodsID
        {
            get { return goodsID;}
            set { goodsID = value;}
        }
        public string EmployeeID
        {
            get { return employeeID ; }
            set {employeeID  = value; }
        }
        public string CompanyName
        {
            get { return companyName ; }
            set { companyName = value; }
        }
        public string DepotName
        {
            get { return depotName ; }
            set { depotName = value; }
        }
        public string GoodsName
        {
            get { return goodsName ; }
            set { goodsName = value; }
        }
        public int GoodsNum
        {
            get { return goodsNum ; }
            set { goodsNum = value; }
        }
        public string GoodsUnit
        {
            get { return goodsUnit ; }
            set { goodsUnit = value; }
        }
        public float GoodsJHPrice
        {
            get { return goodsJHPrice;}
            set { goodsJHPrice = value;}
        }
        public float GoodsSellPrice
        {
            get { return goodsSellPrice;}
            set { goodsSellPrice = value;}
        }
        public float GoodsNeedPay
        {
            get { return goodsNeedPay;}
            set { goodsNeedPay  = value; }
        }
        public float GoodsHasPay
        {
            get { return goodsHasPay;}
            set { goodsHasPay = value;}
        }
        public string GoodsRemark
        {
            get { return goodsRemark; }
            set { goodsRemark = value; }
        }
        public DateTime GoodsTime
        {
            get { return goodsTime; }
            set { goodsTime = value; }
        }
        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }
    }
}
