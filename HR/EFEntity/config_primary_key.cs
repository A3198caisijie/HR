using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Config_primary_key//关键字设置，包括人力资源管理，薪酬发放，激励管理，调动管理，薪酬标准，培训
    {/* 	prk_id : 主键，自动增长列                                                                       */
        /* 	primary_key_table : 关键字所涉及的数据库表名                                                        */
        /* 	primary_key : 关键字                                                                  */
        /* 	key_name : 中文关键字                                                                  */
        /* 	primary_key_status : 是否为关键字                                                             */
        [Key]
        public int prk_id { get; set; }
        public string primary_key_table { get; set; }
        public string primary_key { get; set; }
        public string key_name { get; set; }
        public bool primary_key_status { get; set; }

    }
}
