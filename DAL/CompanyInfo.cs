using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class CompanyInfo
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.CompanyInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CompanyInfo(");
            strSql.Append("CompanyID,CompanyName,CompanyDirector,CompanyPhone,CompanyAddress,CompanyRemarks,ReDateTime,Flag)");
            strSql.Append(" values (");
            strSql.Append("@CompanyID,@CompanyName,@CompanyDirector,@CompanyPhone,@CompanyAddress,@CompanyRemarks,@ReDateTime,@Flag)");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyDirector", SqlDbType.NVarChar,50),
                    new SqlParameter("@CompanyPhone", SqlDbType.NVarChar,50),
                    new SqlParameter("@CompanyAddress",SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyRemarks", SqlDbType.NVarChar,200),
					new SqlParameter("@ReDateTime", SqlDbType.DateTime),
					new SqlParameter("@Flag", SqlDbType.Int)};
            parameters[0].Value = model.CompanyID;
            parameters[1].Value = model.CompanyName;
            parameters[2].Value = model.CompanyDirector;
            parameters[3].Value = model.CompanyPhone;
            parameters[4].Value = model.CompanyAddress;
            parameters[5].Value = model.CompanyRemarks;
            parameters[6].Value = model.ReDateTime;
            parameters[7].Value = model.Flag;
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
        public bool Update(Model.CompanyInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CompanyInfo set ");
            strSql.Append("CompanyName=@CompanyName,");
            strSql.Append("CompanyDirector=@CompanyDirector,");
            strSql.Append("CompanyPhone=@CompanyPhone,");
            strSql.Append("CompanyAddress=@CompanyAddress,");
            strSql.Append("CompanyRemarks=@CompanyRemarks,");
            strSql.Append("ReDateTime=@ReDateTime,");
            strSql.Append("Flag=@Flag");
            strSql.Append(" where CompanyID=@CompanyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyDirector", SqlDbType.NVarChar,50),
                    new SqlParameter("@CompanyPhone", SqlDbType.NVarChar,50),
                    new SqlParameter("@CompanyAddress",SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyRemarks", SqlDbType.NVarChar,200),
					new SqlParameter("@ReDateTime", SqlDbType.DateTime),
					new SqlParameter("@Flag", SqlDbType.Int)};
            parameters[0].Value = model.CompanyID;
            parameters[1].Value = model.CompanyName;
            parameters[2].Value = model.CompanyDirector;
            parameters[3].Value = model.CompanyPhone;
            parameters[4].Value = model.CompanyAddress;
            parameters[5].Value = model.CompanyRemarks;
            parameters[6].Value = model.ReDateTime;
            parameters[7].Value = model.Flag;

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
        public bool Delete(Model.CompanyInfo model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CompanyInfo ");
            strSql.Append(" where CompanyID=@CompanyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = model.CompanyID;

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
            strSql.Append("select CompanyID as 供应商编号,CompanyName as 供应商名称, CompanyDirector as 负责人,CompanyPhone as 联系电话,CompanyAddress as 供应商地址,ReDateTime as 供应时间,CompanyRemarks as 备注 from CompanyInfo");
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
            strSql.Append("select CompanyID as 供应商编号,CompanyName as 供应商名称, CompanyDirector as 负责人,CompanyPhone as 联系电话,CompanyAddress as 供应商地址,ReDateTime as 供应时间,CompanyRemarks as 备注 from CompanyInfo");
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
    }
}
