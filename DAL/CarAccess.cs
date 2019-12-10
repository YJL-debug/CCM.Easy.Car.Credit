using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CCM.Easy.Car.Credit.IDAL;
using Common;
namespace CCM.Easy.Car.Credit.BLL
{
    /// <summary>
    /// 车辆
    /// </summary>
    public class CarAccess : IDataAccess
    {
        
        /// <summary>
        /// 车辆添加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add<T>(T model)
        {
            //获取主键的方法
            //Type ty = typeof(T);
            //PropertyInfo propertyInfo= ty.GetProperties().Where(s => s.GetCustomAttributes(typeof(KeyAttribute), false).Length > 0).FirstOrDefault();
            //string keyname = propertyInfo.Name;

            throw new NotImplementedException();
        }
        /// <summary>
        /// 车辆删除(修改状态)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Delete<T>(T model)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 车辆修改
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataSet Show<T>(T model)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 车辆显示
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Update<T>(T model)
        {
            throw new NotImplementedException();
        }
    }
}
