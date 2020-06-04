using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Config_file_second_kind//二级机构设置
    {
        //fsk_id : 主键，自动增长列
        //first_kind_id : 一级机构编号
        //first_kind_name : 一级机构名称
        //second_kind_id : 二级机构编号
        //second_kind_name : 二级机构名称
        //second_salary_id : 二级机构薪酬发放责任人编号
        //second_sale_id : 二级机构销售责任人编号
        [Key]
        public int fsk_id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public string second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public string second_salary_id { get; set; }
        public string second_sale_id { get; set; }

    }
}
