using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BonusModel
    {
        /* 	bon_id : 主键，自动增长列                                                                       */
        /* 	major_kind_id : 职位分类编号                                                                  */
        /* 	major_kind_name : 职位分类名称                                                                */
        /* 	major_id : 职位编号                                                                         */
        /* 	major_name : 职位名称                                                                       */
        /* 	human_id : 人力资源档案编号                                                                     */
        /* 	human_name : 姓名                                                                         */
        /* 	bonus_item : 激励项目名称                                                                     */
        /* 	bonus_worth : 激励价值                                                                      */
        /* 	bonus_degree : 激励等级                                                                     */
        /* 	remark : 备注                                                                             */
        /* 	register : 登记人                                                                          */
        /* 	checker : 复核人                                                                           */
        /* 	regist_time : 登记时间                                                                      */
        /* 	check_time : 复核时间                                                                       */
        /* 	check_status : 复核状态                                                                     */
        public int bon_id { get; set; }
        public string major_kind_id { get; set; }
        public string major_kind_name { get; set; }
        public string major_id { get; set; }
        public string major_name { get; set; }
        public string human_id { get; set; }
        public string human_name { get; set; }
        public string bonus_item { get; set; }
        public string bonus_worth { get; set; }
        public string bonus_degree { get; set; }
        public string remark { get; set; }
        public string register { get; set; }
        public string checker { get; set; }
        public DateTime regist_time { get; set; }
        public DateTime check_time { get; set; }
        public int check_status { get; set; }

    }
}
