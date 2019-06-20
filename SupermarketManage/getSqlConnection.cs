using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SupermarketManage
{
    class getSqlConnection
    {
        string sql = @"Data Source=WP521\WANGPENG;Initial Catalog=SUPERMARKET;Integrated Security=True";
        SqlConnection conn = null;
        public SqlConnection GetCon()
        {
            conn = new SqlConnection(sql);
            conn.Open();
            return conn;
        }
    }
}
