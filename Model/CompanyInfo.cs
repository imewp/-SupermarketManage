using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CompanyInfo
    {
        string companyID;
        string companyName;
        string companyDirector;
        string companyPhone;
        string companyAddress;
        string companyRemarks;
        int reDateTime;
        int flag;
        public string CompanyID
        {
            get { return companyID;}
            set { companyID = value;}
        }
        public string CompanyName
        {
            get { return companyName;}
            set { companyName = value;}
        }

        public string CompanyDirector
        {
            get { return companyDirector;}
            set { companyDirector = value; }
        }
         
        public string CompanyPhone
        {
            get { return companyPhone;}
            set { companyPhone  = value;}
        }
        public string CompanyAddress
        {
            get { return companyAddress;}
            set { companyAddress = value;}
        }
        public string CompanyRemarks
        {
            get { return companyRemarks;}
            set { companyRemarks  = value; }
        }
        public int ReDateTime
        {
            get { return reDateTime;}
            set { reDateTime = value;}
        }
        public int Flag
        {
            get { return flag;}
            set { flag = value; }
        }
    }
}
