using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TrainingModel
    { /* 	tra_id : 主键，自动增长列                                                                       */
        /* 	major_kind_id : 职位分类编号                                                                  */
        /* 	major_kind_name : 职位分类名称                                                                */
        /* 	major_id : 职位名称                                                                         */
        /* 	major_name : 职位名称                                                                       */
        /* 	human_id : 人力资源档案编号                                                                     */
        /* 	human_name : 姓名                                                                         */
        /*	training_item ：培训项目										*/
        /* 	training_time : 培训时间                                                                    */
        /* 	training_hour : 培训课时                                                                    */
        /* 	training_degree : 培训成绩等级                                                                */
        /* 	register : 登记人                                                                          */
        /* 	checker : 复核人                                                                           */
        /* 	regist_time : 登记时间                                                                      */
        /* 	check_time : 复核时间                                                                       */
        /* 	checkstatus : 培训复核状态                                                                    */
        /* 	remark : 备注                                                                             */
        public int tra_id { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
        public string major_id { get; set; }
        public string major_name { get; set; }
        public string human_id { get; set; }
        public string human_name { get; set; }
        public string training_item { get; set; }
        public DateTime training_time { get; set; }
        public int training_hour { get; set; }
        public string training_degree { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public DateTime regist_time { get; set; }
        public DateTime check_time { get; set; }
        public int checkstatus { get; set; }
        public string remark { get; set; }
    }
}
