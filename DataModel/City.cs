using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// 城市表
    /// </summary>
    public class City
    {
        /// <summary>
        /// 城市编号
        /// </summary>
        [Key]
        public int CityId	 { get; set; }
        /// <summary>
        /// 城市名称
        /// </summary>
        public string CityName { get; set; }

    }
}
