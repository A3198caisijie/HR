using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Config_question_first_kind//试题一级分类设置
    { 
        /* 	qfk_id : 主键，自动增长列                                                                       */
        /* 	first_kind_id : 试题一级分类编号                                                                */
        /* 	first_kind_name : 试题一级分类名称                                                              */
        [Key]
        public int qfk_id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }

    }
}
