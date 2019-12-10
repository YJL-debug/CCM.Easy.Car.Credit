using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 银行类型表
    /// </summary>
    public class BankType
    {
        /// <summary>
        /// 银行编号
        /// </summary>
        [Key]
        public int BankId	 { get; set; }
        /// <summary>
        /// 银行名称
        /// </summary>
        public string BankName { get; set; }
    }
}
