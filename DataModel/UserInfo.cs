using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        [Key]
        public int UserId	      { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string UserEmail    { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd	      { get; set; }
        /// <summary>
        /// 添加用户的时间
        /// </summary>
        public DateTime UserAddTime	  { get; set; }
        /// <summary>
        /// 用户的真实姓名
        /// </summary>
        public string UserTrueName { get; set; }
        /// <summary>
        /// 用户的身份证号码
        /// </summary>
        public string UserNumber   { get; set; }
        /// <summary>
        /// 用户的手机号
        /// </summary>
        public string UserTelPhone { get; set; }
        /// <summary>
        /// 用户学历
        /// </summary>
        public string UserEducation { get; set; }
        /// <summary>
        /// 用户的工作信息
        /// </summary>
        public string UserJobInfo   { get; set; }
        /// <summary>
        /// 用户的职位
        /// </summary>
        public string UserPosition { get; set; }
        /// <summary>
        /// 用户的信用
        /// </summary>
        public string UserCredit	  { get; set; }
        /// <summary>
        /// 用户的平均收入
        /// </summary>
        public decimal UserIncome	  { get; set; }
        /// <summary>
        /// 用户的银行卡号
        /// </summary>
        public string UserBandCard { get; set; }
        /// <summary>
        /// 银行编号，关联银行类型表
        /// </summary>
        public int BankId	      { get; set; }
    }
}
