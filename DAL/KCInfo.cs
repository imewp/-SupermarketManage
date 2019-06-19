using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class KCInfo
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.KCInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into KCInfo(");
            strSql.Append("GoodsID,GoodsName,CompanyName,DepotName,GoodsNum,AlarmNum)");
            strSql.Append(" values (");
            strSql.Append("@GoodsID,@GoodsName,@CompanyName,@DepotName,@GoodsNum,@AlarmNum)");
            SqlParameter[] parameters = {
					new SqlParameter("@GoodsID", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepotName", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsNum", SqlDbType.Int),
					new SqlParameter("@AlarmNum",SqlDbType.Int)};
            parameters[0].Value = model.GoodsID;
            parameters[1].Value = model.GoodsName;
            parameters[2].Value = model.CompanyName;
            parameters[3].Value = model.DepotName;
            parameters[4].Value = model.GoodsNum;
            parameters[5].Value = model.AlarmNum;
            int rows = DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.KCInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update KCInfo set ");
            strSql.Append("GoodsName=@GoodsName,");
            strSql.Append("CompanyName=@CompanyName,");
            strSql.Append("DepotName=@DepotName,");
            strSql.Append("GoodsNum=@GoodsNum,");
            strSql.Append("AlarmNum=@AlarmNum");
            strSql.Append(" where GoodsID=@GoodsID ");
            SqlParameter[] parameters = {
				new SqlParameter("@GoodsID", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepotName", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsNum", SqlDbType.Int),
					new SqlParameter("@AlarmNum",SqlDbType.Int)};
            parameters[0].Value = model.GoodsID;
            parameters[1].Value = model.GoodsName;
            parameters[2].Value = model.CompanyName;
            parameters[3].Value = model.DepotName;
            parameters[4].Value = model.GoodsNum;
            parameters[5].Value = model.AlarmNum;

            int rows = DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.KCInfo model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from KCInfo ");
            strSql.Append(" where GoodsID=@GoodsID ");
            SqlParameter[] parameters = {
					new SqlParameter("@GoodsID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = model.GoodsID;
            int rows = DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select GoodsID as 商品编号, GoodsName as 商品名称, CompanyName as 供应商名称, DepotName as 仓库名称, GoodsNum as 商品数量, AlarmNum as 警报数量 from KCInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
        /// <summary>
        /// 获得数据列表，无参数
        /// </summary>
        public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select GoodsID as 商品编号, GoodsName as 商品名称, CompanyName as 供应商名称, DepotName as 仓库名称, GoodsNum as 商品数量, AlarmNum as 警报数量 from KCInfo");
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
    }
}
