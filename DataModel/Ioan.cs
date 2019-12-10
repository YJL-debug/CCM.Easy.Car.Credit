using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 贷款表
    /// </summary>
    public class Ioan
    {
        /// <summary>
        /// 贷款编号
        /// </summary>
        [Key]
        public int IoanId	  { get; set; }
        /// <summary>
        /// 用户编号 关联用户信息表
        /// </summary>
        public int UserId	  { get; set; }
        /// <summary>
        /// 可贷款额度
        /// </summary>
        public decimal IoanMoney { get; set; }
    }
}
