using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 品牌类型表
    /// </summary>
    public class BrandType
    {
        /// <summary>
        /// 品牌编号
        /// </summary>
        [Key]
        public int BrandId	  { get; set; }
        /// <summary>
        /// 品牌名称（类型名称）
        /// </summary>
        public string BrandName { get; set; }
        /// <summary>
        /// pid
        /// </summary>
        public int PId { get; set; }
    }
}
