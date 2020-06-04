using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Engage_resume//简历管理
	{
		//	res_id smallint identity not null,主键，自动增长列
		[Key]
		public int res_id { get; set; }
		//human_name varchar(60) null,姓名
		public string human_name { get; set; }
		//engage_type varchar(30) null,招聘类型
		public string engage_type { get; set; }
		//human_address varchar(200) null,地址
		public string human_address { get; set; }
		//human_postcode varchar(10) null,邮编
		public string human_postcode { get; set; }
		//human_major_kind_id char (2) null,职位分类编号
		public string human_major_kind_id { get; set; }
		//human_major_kind_name varchar(60) null,职位分类名称
		public string human_major_kind_name { get; set; }
		//human_major_id char (2) null,职位编号
		public string human_major_id { get; set; }
		//human_major_name varchar(60) null,职位名称
		public string human_major_name { get; set; }
		//human_telephone varchar(60) null,电话号码
		public string human_telephone { get; set; }
		//human_homephone varchar(60) null,家庭电话
		public string human_homephone { get; set; }
		//human_mobilephone varchar(60) null,手机
		public string human_mobilephone { get; set; }
		//human_email varchar(60) null,Email
		public string human_email { get; set; }
		//human_hobby varchar(200) null,兴趣爱好
		public string human_hobby { get; set; }
		//human_specility varchar(200) null,特长
		public string human_specility { get; set; }
		//human_sex char (2) null,性别
		public string human_sex { get; set; }
		//human_religion varchar(60) null,宗教信仰
		public string human_religion { get; set; }
		//human_party varchar(60) null,政治面貌
		public string human_party { get; set; }
		//human_nationality varchar(60) null,国籍
		public string human_nationality { get; set; }
		//human_race varchar(60) null,民族
		public string human_race { get; set; }
		//human_birthday datetime null,生日
		public DateTime human_birthday { get; set; }
		//human_age smallint null,年龄
		public int human_age { get; set; }
		//human_educated_degree varchar(60) null,教育程度
		public string human_educated_degree { get; set; }
		//human_educated_years smallint null,教育年限
		public int human_educated_years { get; set; }
		//human_educated_major varchar(60) null,专业
		public string human_educated_major { get; set; }
		//human_college varchar(60) null,毕业院校
		public string human_college { get; set; }
		//human_idcard varchar(60) null,身份证号
		public string human_idcard { get; set; }
		//human_birthplace varchar(200) null,出生地
		public string human_birthplace { get; set; }
		//demand_salary_standard numeric(15,2) null,薪酬标准
		public double demand_salary_standard { get; set; }
		//human_history_records text null,个人履历
		public string human_history_records { get; set; }
		//remark text null,备注
		public string remark { get; set; }
		//recomandation text null,推荐意见
		public string recomandation { get; set; }
		//human_picture varchar(60) null,照片
		public string human_picture { get; set; }
		//attachment_name varchar(60) null,档案附件
		public string attachment_name { get; set; }
		//check_status smallint null,复核状态
		public int check_status { get; set; }
		//register varchar(60) null,登记人
		public string register { get; set; }
		//regist_time datetime null,登记时间
		public DateTime regist_time { get; set; }
		//checker varchar(60) null,复核人姓名
		public string checker { get; set; }
		//check_time datetime null,复核时间
		public DateTime check_time { get; set; }
		//interview_status smallint null,面试状态
		public int interview_status { get; set; }
		//total_points float null,总分
		public string total_points { get; set; }
		//test_amount smallint null,考试次数
		public int test_amount { get; set; }
		//test_checker varchar(60) null,测试复核人
		public string test_checker { get; set; }
		//test_check_time datetime null,测试复核时间
		public DateTime test_check_time { get; set; }
		//pass_register varchar(60) null,通过登记人姓名
		public string pass_register { get; set; }
		//pass_regist_time datetime null,通过登记时间
		public DateTime pass_regist_time { get; set; }
		//pass_checker varchar(60) null,通过复核人姓名
		public string pass_checker { get; set; }
		//pass_check_time datetime null,通过复核时间
		public DateTime pass_check_time { get; set; }
		//pass_check_status smallint null,通过的复核状态
		public int pass_check_status { get; set; }
		//pass_checkComment varchar(60) null,录用申请审核意见
		public string pass_checkComment { get; set; }
		//pass_passComment varchar(60) null,录用申请审批意见
		public string pass_passComment { get; set; }

	}
}
