using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Config_question_second_kind//试题二级分类设置
    {
        /* 	qsk_id : 主键，自动增长列                                                                       */
        /* 	first_kind_id : 试题一级分类编号                                                                */
        /* 	first_kind_name : 试题一级分类名称                                                              */
        /* 	second_kind_id : 试题二级分类编号                                                               */
        /* 	second_kind_name : 试题二级分类名称                                                             */
        [Key]
        public int qsk_id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }

    }
}
