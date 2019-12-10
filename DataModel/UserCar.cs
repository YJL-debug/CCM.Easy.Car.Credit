using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 用户车辆表
    /// </summary>
    public class UserCar
    {
        /// <summary>
        /// 用户车辆的编号
        /// </summary>
        [Key]
        public int UserCarId	   { get; set; }
        /// <summary>
        /// 用户编号 关联用户信息表
        /// </summary>
        public int UserId	   { get; set; }
        /// <summary>
        /// 车辆编号 关联车辆信息表
        /// </summary>
        public int CarId	       { get; set; }
        /// <summary>
        /// 车辆加入时间 
        /// </summary>
        public DateTime CarJoinTime { get; set; }
        /// <summary>
        /// 用户车辆状态
        /// </summary>
        public int UserCarState { get; set; }
    }
}
