using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class SellGoodsInfo
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.SellGoodsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SellGoodsInfo(");
            strSql.Append("SellID,GoodsID,EmployeeID,CompanyName,DepotName,GoodsName,SellGoodsNum,SellGoodsPrice,SellNeedPay,SellHasPay,SellRemark,Flag,SellGoodsTime)");
            strSql.Append(" values (");
            strSql.Append("@SellID,@GoodsID,@EmployeeID,@CompanyName,@DepotName,@GoodsName,@SellGoodsNum,@SellGoodsPrice,@SellNeedPay,@SellHasPay,@SellRemark,@Flag,@SellGoodsTime)");
            SqlParameter[] parameters = {
					new SqlParameter("@SellID", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepotName", SqlDbType.NVarChar,50),
                    new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@SellGoodsNum",SqlDbType.Int),
					new SqlParameter("@SellGoodsPrice", SqlDbType.Float),
					new SqlParameter("@SellNeedPay", SqlDbType.Float),
                    new SqlParameter("@SellHasPay", SqlDbType.Float),
					new SqlParameter("@SellRemark", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Flag",SqlDbType.Int),
                    new SqlParameter("@SellGoodsTime", SqlDbType.DateTime)};
            parameters[0].Value = model.SellID;
            parameters[1].Value = model.GoodsID;
            parameters[2].Value = model.EmployeeID;
            parameters[3].Value = model.CompanyName;
            parameters[4].Value = model.DepotName;
            parameters[5].Value = model.GoodsName;
            parameters[6].Value = model.SellGoodsNum;
            parameters[7].Value = model.SellGoodsPrice;
            parameters[8].Value = model.SellNeedPay;
            parameters[9].Value = model.SellHasPay;
            parameters[10].Value = model.SellRemark;
            parameters[11].Value = model.Flag;
            parameters[12].Value = model.SellGoodsTime;

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
        public bool Update(Model.SellGoodsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SellGoodsInfo set ");
            strSql.Append("GoodsID=@GoodsID,");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("CompanyName=@CompanyName,");
            strSql.Append("DepotName=@DepotName,");
            strSql.Append("GoodsName=@GoodsName,");
            strSql.Append("SellGoodsNum=@SellGoodsNum,");
            strSql.Append("SellGoodsPrice=@SellGoodsPrice,");
            strSql.Append("SellNeedPay=@SellNeedPay,");
            strSql.Append("SellHasPay=@SellHasPay,");
            strSql.Append("SellRemark=@SellRemark");
            strSql.Append("Flag=@Flag");
            strSql.Append("SellGoodsTime=@SellGoodsTime");
            strSql.Append(" where SellID=@SellID ");
            SqlParameter[] parameters = {
						new SqlParameter("@SellID", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepotName", SqlDbType.NVarChar,50),
                    new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@SellGoodsNum",SqlDbType.Int),
					new SqlParameter("@SellGoodsPrice", SqlDbType.Float),
					new SqlParameter("@SellNeedPay", SqlDbType.Float),
                    new SqlParameter("@SellHasPay", SqlDbType.Float),
					new SqlParameter("@SellRemark", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Flag",SqlDbType.Int),
                    new SqlParameter("@SellGoodsTime", SqlDbType.DateTime)};
            parameters[0].Value = model.SellID;
            parameters[1].Value = model.GoodsID;
            parameters[2].Value = model.EmployeeID;
            parameters[3].Value = model.CompanyName;
            parameters[4].Value = model.DepotName;
            parameters[5].Value = model.GoodsName;
            parameters[6].Value = model.SellGoodsNum;
            parameters[7].Value = model.SellGoodsPrice;
            parameters[8].Value = model.SellNeedPay;
            parameters[9].Value = model.SellHasPay;
            parameters[10].Value = model.SellRemark;
            parameters[11].Value = model.Flag;
            parameters[12].Value = model.SellGoodsTime;

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
            strSql.Append("select SellID as 销售编号,GoodsID as 商品编号,EmployeeID as 员工编号,CompanyName as 供应商名称,DepotName as 仓库名称,GoodsName as 商品名称 ,SellGoodsNum as 销售数量,SellGoodsTime as 销售时间,SellGoodsPrice as 销售价格,SellNeedPay 应付价格,SellHasPay as 实付价格,SellRemark as 备注 from SellGoodsInfo");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.SellGoodsInfo model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SellGoodsInfo ");
            strSql.Append(" where SellID=@SellID ");
            SqlParameter[] parameters = {
					new SqlParameter("@SellID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = model.SellID;

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
        /// 获得数据列表，无参数
        /// </summary>
        public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SellID as 销售编号,GoodsID as 商品编号,EmployeeID as 员工编号,CompanyName as 供应商名称,DepotName as 仓库名称,GoodsName as 商品名称 ,SellGoodsNum as 销售数量,SellGoodsTime as 销售时间,SellGoodsPrice as 销售价格,SellNeedPay 应付价格,SellHasPay as 实付价格,SellRemark as 备注 from SellGoodsInfo");
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
    }
}
