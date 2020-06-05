using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Config_major_kindModel
    { /* 	mfk_id : 主键，自动增长列                                                                       */
        /* 	major_kind_id : 职位分类编号                                                                  */
        /* 	major_kind_name : 职分类位名称                                                                */
        public int mfk_id { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
    }
}
