using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Salary_standardModel
    {/* 	ssd_id : 主键，自动增长列                                                                       */
        /* 	standard_id : 薪酬标准单编号                                                                   */
        /* 	standard_name : 薪酬标准单名称                                                                 */
        /* 	designer : 制定者名字                                                                        */
        /* 	register : 登记人                                                                          */
        /* 	checker : 复核人                                                                           */
        /* 	changer : 变更人                                                                           */
        /* 	regist_time : 登记时间                                                                      */
        /* 	check_time : 复核时间                                                                       */
        /* 	change_time : 变更时间                                                                      */
        /* 	salary_sum : 薪酬总额                                                                       */
        /* 	check_status : 是否经过复核                                                                   */
        /* 	change_status : 更改状态                                                                    */
        /* 	check_comment : 复核意见                                                                   */
        /* 	remark : 备注                                                                             */
        public int ssd_id { get; set; }
        public string standard_id { get; set; }
        public string standard_name { get; set; }
        public string designer { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public string changer { get; set; }
        public DateTime regist_time { get; set; }
        public DateTime check_time { get; set; }
        public DateTime change_time { get; set; }
        public double salary_sum { get; set; }
        public int check_status { get; set; }
        public int change_status { get; set; }
        public string check_comment { get; set; }
        public string remark { get; set; }
    }
}
