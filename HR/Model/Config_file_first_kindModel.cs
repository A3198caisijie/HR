using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Config_file_first_kindModel
    {
        //ffk_id : 主键，自动增长列
        //first_kind_id : 一级机构编号
        //first_kind_name : 一级机构名称
        //first_kind_salary_id : 一级机构薪酬发放责任人编号
        //first_kind_sale_id : 一级机构销售责任人编号
        public int ffk_id { get; set; }
        public string first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public string first_kind_salary_id { get; set; }
        public string first_kind_sale_id { get; set; }
    }
}
