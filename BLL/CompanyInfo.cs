using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class CompanyInfo
    {
        private readonly DAL.CompanyInfo dal = new DAL.CompanyInfo();

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.CompanyInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.CompanyInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.CompanyInfo model)
        {
            return dal.Delete(model);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 获得数据列表，无参数
        /// </summary>
        public DataSet GetList()
        {
            return dal.GetList();
        }
    }
}
