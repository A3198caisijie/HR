using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Salary_standard_detailsModel
    {/* 	sdt_id : 主键，自动增长列                                                                       */
        /* 	standard_id : 薪酬标准单编号                                                                   */
        /* 	standard_name : 薪酬标准单名称                                                                 */
        /* 	item_id : 薪酬项目序号                                                                        */
        /* 	item_name : 薪酬项目名称                                                                      */
        /* 	salary : 薪酬金额                                                                           */
        public int sdt_id { get; set; }
        public string standard_id { get; set; }
        public string standard_name { get; set; }
        public int item_id { get; set; }
        public string item_name { get; set; }
        public double salary { get; set; }
    }
}
