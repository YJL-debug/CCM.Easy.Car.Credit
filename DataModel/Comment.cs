using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 评论表
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// 评论编号
        /// </summary>
        [Key]
        public int CommentId	   { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string CommentContent { get; set; }
        /// <summary>
        /// 用户编号，关联用户信息表
        /// </summary>
        public int UserId	       { get; set; }
        /// <summary>
        /// 车辆编号，关联车辆信息表
        /// </summary>
        public int CarId	       { get; set; }
        /// <summary>
        /// 评论的时间
        /// </summary>
        public DateTime CommentTime { get; set; }
    }
}
