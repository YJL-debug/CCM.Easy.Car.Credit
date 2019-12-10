using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CCM.Easy.Car.Credit.IDAL
{
    public interface IDataAccess
    {
        /// <summary>
        /// 接口添加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        int Add<T>(T model);
        /// <summary>
        /// 接口删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        int Delete<T>(T model);
        /// <summary>
        /// 接口修改
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        int Update<T>(T model);
        /// <summary>
        /// 接口显示
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        DataSet Show<T>(T model);
    }
}
