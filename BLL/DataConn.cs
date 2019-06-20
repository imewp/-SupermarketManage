using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class DataConn
    {
        public SqlConnection GetCon()
        {
            return DAL.DBHelper.GetCon();
        }
    }
}
