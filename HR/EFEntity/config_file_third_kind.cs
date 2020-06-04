using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Config_file_third_kind//三级机构设置
    {
        /* 	ftk_id : 主键，自动增长列                                                                       */
        /* 	first_kind_id : 一级机构编号                                                                  */
        /* 	first_kind_name : 一级机构名称                                                                */
        /* 	second_kind_id : 二级机构编号                                                                 */
        /* 	second_kind_name : 二级机构名称                                                               */
        /* 	third_kind_id : 三级机构编号                                                                  */
        /* 	third_kind_name : 三级机构名称                                                                */
        /* 	third_kind_sale_id : 三级机构销售责任人编号                                                        */
        /* 	third_kind_is_retail : 三级机构是否为零售店                                                       */
        [Key]
        public int ftk_id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public string third_kind_id { get; set; }
        public string third_kind_name { get; set; }
        public string third_kind_sale_id { get; set; }
        public string third_kind_is_retail { get; set; }
    }
}
