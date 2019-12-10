using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 用户还款信息表
    /// </summary>
    public class Repay
    {
        /// <summary>
        /// 用户还款的编号
        /// </summary>
        [Key]
        public int RepayId    { get; set; }
        /// <summary>
        /// 用户编号 关联用户信息表
        /// </summary>
        public int UserId	   { get; set; }
        /// <summary>
        /// 贷款编号，关联贷款表
        /// </summary>
        public int IoanId	   { get; set; }
        /// <summary>
        /// 已贷款额度
        /// </summary>
        public decimal IoanMoney { get; set; }
        /// <summary>
        /// 已还款额度
        /// </summary>
        public decimal RepayMoney { get; set; }
        /// <summary>
        /// 还款状态
        /// </summary>
        public int RepayState { get; set; }
    }
}
