using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class KCInfo
    {
        private readonly DAL.KCInfo dal = new DAL.KCInfo();

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.KCInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.KCInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.KCInfo model)
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
