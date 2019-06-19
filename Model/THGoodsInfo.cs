using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class THGoodsInfo
    {
        string thGoodsID;
        string kcID;
        string goodsID;
        string sellID;
        string employeeID;
        string thGoodsName;
        int thGoodsNum;
        DateTime thGoodsTime;
        float thGoodsPrice;
        float thNeedPay;
        float thHasPay;
        string thGoodsResult;

        public string THGoodsID
        {
            get { return thGoodsID; }
            set { thGoodsID = value; }
        }
        public string KCID
        {
            get { return kcID; }
            set { kcID = value; }
        }
        public string GoodsID
        {
            get { return goodsID; }
            set { goodsID = value; }
        }
        public string SellID
        {
            get { return sellID; }
            set { sellID = value; }
        }
        public string EmploayeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public string THGoodsName
        {
            get { return thGoodsName; }
            set { thGoodsName = value; }
        }
        public int THGoodsNum
        {
            get { return thGoodsNum; }
            set { thGoodsNum = value; }
        }
        public DateTime THGoodsTime
        {
            get { return thGoodsTime; }
            set { thGoodsTime = value; }
        }
        public float THGoodsPrice
        {
            get { return thGoodsPrice; }
            set { thGoodsPrice = value; }
        }
        public float THNeedPay
        {
            get { return thNeedPay; }
            set { thNeedPay = value; }
        }
        public float THHasPay
        {
            get { return thHasPay; }
            set { thHasPay = value; }
        }
        public string THGoodsResult
        {
            get { return thGoodsResult; }
            set { thGoodsResult = value; }
        }
    }
}
