using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Config_major_kind//职位分类设置
    {
        /* 	mfk_id : 主键，自动增长列                                                                       */
        /* 	major_kind_id : 职位分类编号                                                                  */
        /* 	major_kind_name : 职分类位名称                                                                */
        [Key]
        public int mfk_id { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }

    }
}
