using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 商家信息表
    /// </summary>
    public class ShopInfo
    {
        /// <summary>
        /// 商家编号
        /// </summary>
        [Key]
        public int ShopId	     { get; set; }
        /// <summary>
        /// 商家名称
        /// </summary>
        public string ShopName	 { get; set; }
        /// <summary>
        /// 城市编号 关联城市表
        /// </summary>
        public int CityId	     { get; set; }
        /// <summary>
        /// 商家具体地址
        /// </summary>
        public string ShopAddress  { get; set; }
        /// <summary>
        /// 商家密码
        /// </summary>
        public string ShopPwd      { get; set; }
        /// <summary>
        /// 商家状态
        /// </summary>
        public int ShopState { get; set; }
    }
}
