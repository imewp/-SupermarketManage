using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class KCInfo
    {
        string goodsID;
        string goodsName;
        string companyName;
        string depotName;
        int goodsNum;
        int alarmNum;
        public string GoodsID
        {
            get { return goodsID; }
            set { goodsID = value; }
        }
        public string GoodsName
        {
            get { return goodsName; }
            set { goodsName = value; }
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
        public int GoodsNum
        {
            get { return goodsNum; }
            set { goodsNum = value; }
        }
        public int AlarmNum
        {
            get { return alarmNum; }
            set { alarmNum = value; }
        }
    }
}
