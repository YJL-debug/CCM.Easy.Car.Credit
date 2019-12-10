using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 车辆信息表
    /// </summary>
    public class CarInfo
    {
        /// <summary>
        /// 车辆编号
        /// </summary>
        [Key]
        public int CarId    { get; set; }
        /// <summary>
        /// 品牌编号 关联品牌类型表
        /// </summary>
        public int BrandId  { get; set; }
        /// <summary>
        /// 车辆名称
        /// </summary>
        public string CarName  { get; set; }
        /// <summary>
        /// 车辆价格
        /// </summary>
        public decimal CarPrice { get; set; }
        /// <summary>
        /// 商家编号 关联商家信息表
        /// </summary>
        public int ShopId   { get; set; }
        /// <summary>
        /// 车辆图片
        /// </summary>
        public string CarImg   { get; set; }
        /// <summary>
        /// 车辆状态
        /// </summary>
        public int CarState { get; set; }
    }
}
