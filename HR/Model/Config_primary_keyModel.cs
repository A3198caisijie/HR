using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Config_primary_keyModel
    {/* 	prk_id : 主键，自动增长列                                                                       */
        /* 	primary_key_table : 关键字所涉及的数据库表名                                                        */
        /* 	primary_key : 关键字                                                                  */
        /* 	key_name : 中文关键字                                                                  */
        /* 	primary_key_status : 是否为关键字                                                             */
        public int prk_id { get; set; }
        public string primary_key_table { get; set; }
        public string primary_key { get; set; }
        public string key_name { get; set; }
        public bool primary_key_status { get; set; }
    }
}
