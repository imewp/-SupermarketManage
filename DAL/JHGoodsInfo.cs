using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class JHGoodsInfo
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.JHGoodsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into JHGoodsInfo(");
            strSql.Append("GoodsID,EmployeeID,CompanyName,DepotName,GoodsName,GoodsNum,GoodsUnit,GoodsJHPrice,GoodsSellPrice,GoodsNeedPay,GoodsHasPay,GoodsRemark,GoodsTime,Flag)");
            strSql.Append(" values (");
            strSql.Append("@GoodsID,@EmployeeID,@CompanyName,@DepotName,@GoodsName,@GoodsNum,@GoodsUnit,@GoodsJHPrice,@GoodsSellPrice,@GoodsNeedPay,GoodsHasPay,GoodsRemark,GoodsTime,Flag)");
            SqlParameter[] parameters = {
					new SqlParameter("@GoodsID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
                    new SqlParameter("@DepotName",SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsNum",SqlDbType.Int),
					new SqlParameter("@GoodsUnit", SqlDbType.NVarChar,20),
					new SqlParameter("@GoodsJHPrice", SqlDbType.Float),
                    new SqlParameter("@GoodsSellPrice", SqlDbType.Float),
                    new SqlParameter("@GoodsNeedPay", SqlDbType.Float),
                    new SqlParameter("@GoodsHasPay", SqlDbType.Float),
                    new SqlParameter("@GoodsRemark", SqlDbType.NVarChar,200),
					new SqlParameter("@GoodsTime", SqlDbType.DateTime),
					new SqlParameter("@Flag", SqlDbType.Int)};
            parameters[0].Value = model.GoodsID;
            parameters[1].Value = model.EmployeeID;
            parameters[2].Value = model.CompanyName;
            parameters[3].Value = model.DepotName;
            parameters[4].Value = model.GoodsName;
            parameters[5].Value = model.GoodsNum;
            parameters[6].Value = model.GoodsUnit;
            parameters[7].Value = model.GoodsJHPrice;
            parameters[8].Value = model.GoodsSellPrice;
            parameters[9].Value = model.GoodsNeedPay;
            parameters[10].Value = model.GoodsHasPay;
            parameters[11].Value = model.GoodsRemark;
            parameters[12].Value = model.GoodsTime;
            parameters[13].Value = model.Flag;

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
        public bool Update(Model.JHGoodsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update JHGoodsInfo set ");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("CompanyName=@CompanyName,");
            strSql.Append("DepotName=@DepotName,");
            strSql.Append("GoodsName=@GoodsName,");
            strSql.Append("GoodsNum=@GoodsNum,");
            strSql.Append("GoodsUnit=@GoodsUnit,");
            strSql.Append("GoodsJHPrice=@GoodsJHPrice,");
            strSql.Append("GoodsSellPrice=@GoodsSellPrice,");
            strSql.Append("GoodsNeedPay=@GoodsNeedPay");
            strSql.Append("GoodsHasPay=@GoodsHasPay");
            strSql.Append("GoodsRemark=@GoodsRemark");
            strSql.Append("GoodsTime=@GoodsTime");
            strSql.Append("Flag=@Flag");
            strSql.Append(" where GoodsID=@GoodsID ");
            SqlParameter[] parameters = {
					new SqlParameter("@GoodsID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
                    new SqlParameter("@DepotName",SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsNum",SqlDbType.Int),
					new SqlParameter("@GoodsUnit", SqlDbType.NVarChar,20),
					new SqlParameter("@GoodsJHPrice", SqlDbType.Float),
                    new SqlParameter("@GoodsSellPrice", SqlDbType.Float),
                    new SqlParameter("@GoodsNeedPay", SqlDbType.Float),
                    new SqlParameter("@GoodsHasPay", SqlDbType.Float),
                    new SqlParameter("@GoodsRemark", SqlDbType.NVarChar,200),
					new SqlParameter("@GoodsTime", SqlDbType.DateTime),
					new SqlParameter("@Flag", SqlDbType.Int)};
            parameters[0].Value = model.GoodsID;
            parameters[1].Value = model.EmployeeID;
            parameters[2].Value = model.CompanyName;
            parameters[3].Value = model.DepotName;
            parameters[4].Value = model.GoodsName;
            parameters[5].Value = model.GoodsNum;
            parameters[6].Value = model.GoodsUnit;
            parameters[7].Value = model.GoodsJHPrice;
            parameters[8].Value = model.GoodsSellPrice;
            parameters[9].Value = model.GoodsNeedPay;
            parameters[10].Value = model.GoodsHasPay;
            parameters[11].Value = model.GoodsRemark;
            parameters[12].Value = model.GoodsTime;
            parameters[13].Value = model.Flag;

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
        public bool Delete(Model.JHGoodsInfo model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from JHGoodsInfo ");
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
            strSql.Append("select GoodsID as 商品编号,EmployeeID as 操作员编号,CompanyName as 供应商名称,DepotName as 仓库名称,GoodsName as 商品名称,GoodsNum as 商品数量,GoodsUnit as 单位,GoodsJHPrice as 进货单价,GoodsSellPrice as 销售单价,GoodsNeedPay as 应付金额,GoodsHasPay as 实付金额,GoodsRemark as 备注,GoodsTime as 进货时间 from JHGoodsInfo");
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
            strSql.Append("select GoodsID as 商品编号,EmployeeID as 操作员编号,CompanyName as 供应商名称,DepotName as 仓库名称,GoodsName as 商品名称,GoodsNum as 商品数量,GoodsUnit as 单位,GoodsJHPrice as 进货单价,GoodsSellPrice as 销售单价,GoodsNeedPay as 应付金额,GoodsHasPay as 实付金额,GoodsRemark as 备注,GoodsTime as 进货时间 from JHGoodsInfo");
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
    }
}
