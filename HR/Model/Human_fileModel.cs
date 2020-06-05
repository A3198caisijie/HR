using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Human_fileModel
	{//	huf_id smallint identity not null,主键，自动增长列 
		public int huf_id { get; set; }
		//human_id varchar(30) null,档案编号
		public string human_id { get; set; }
		//first_kind_id char (2) null,一级机构编号
		public string first_kind_id { get; set; }
		//first_kind_name varchar(60) null,一级机构名称
		public string first_kind_name { get; set; }
		//second_kind_id char (2) null,二级机构编号
		public string second_kind_id { get; set; }
		//second_kind_name varchar(60) null,二级机构名称
		public string second_kind_name { get; set; }
		//third_kind_id char (2) null,三级机构编号
		public string third_kind_id { get; set; }
		//third_kind_name varchar(60) null,三级机构名称
		public string third_kind_name { get; set; }
		//human_name varchar(60) null,姓名
		public string human_name { get; set; }
		//human_address varchar(200) null,地址
		public string human_address { get; set; }
		//human_postcode varchar(10) null,邮政编码
		public string human_postcode { get; set; }
		//human_pro_designation varchar(60) null,职称
		public string human_pro_designation { get; set; }
		//human_major_kind_id char (2) null,职位分类编号
		public string human_major_kind_id { get; set; }
		//human_major_kind_name varchar(60) null,职位分类名称
		public string human_major_kind_name { get; set; }
		//human_major_id char (2) null,职位编号
		public string human_major_id { get; set; }
		//hunma_major_name varchar(60) null,职位名称
		public string hunma_major_name { get; set; }
		//human_telephone varchar(20) null,电话
		public string human_telephone { get; set; }
		//human_mobilephone char (11) null,手机号码
		public string human_mobilephone { get; set; }
		//human_bank varchar(50) null,开户银行
		public string human_bank { get; set; }
		//human_account varchar(30) null,银行帐号
		public string human_account { get; set; }
		//human_qq varchar(15) null,QQ号码
		public string human_qq { get; set; }
		//human_email varchar(50) null,电子邮件
		public string human_email { get; set; }
		//human_hobby varchar(60) null,爱好
		public string human_hobby { get; set; }
		//human_speciality varchar(60) null,特长
		public string human_speciality { get; set; }
		//human_sex char (2) null,性别
		public string human_sex { get; set; }
		//human_religion varchar(50) null,宗教信仰
		public string human_religion { get; set; }
		//human_party varchar(50) null,政治面貌
		public string human_party { get; set; }
		//human_nationality varchar(50) null,国籍
		public string human_nationality { get; set; }
		//human_race varchar(50) null,民族
		public string human_race { get; set; }
		//human_birthday datetime null,出生日期
		public DateTime human_birthday { get; set; }
		//human_birthplace varchar(50) null,出生地
		public string human_birthplace { get; set; }
		//human_age smallint null,年龄
		public int human_age { get; set; }
		//human_educated_degree varchar(60) null,学历
		public string human_educated_degree { get; set; }
		//human_educated_years smallint null,教育年限
		public int human_educated_years { get; set; }
		//human_educated_major varchar(60) null,学历专业
		public string human_educated_major { get; set; }
		//human_society_security_id varchar(30) null,社会保障号
		public string human_society_security_id { get; set; }
		//human_id_card varchar(20) not null,身份证号
		public string human_id_card { get; set; }
		//remark text null,备注
		public string v { get; set; }
		//salary_standard_id varchar(30) null,薪酬标准编号
		public string salary_standard_id { get; set; }
		//salary_standard_name varchar(60) null,薪酬标准名称
		public string salary_standard_name { get; set; }
		//salary_sum money null,基本薪酬总额
		public double salary_sum { get; set; }
		//demand_salaray_sum money null,应发薪酬总额
		public double demand_salaray_sum { get; set; }
		//paid_salary_sum money null,实发薪酬总额
		public double paid_salary_sum { get; set; }
		//major_change_amount smallint null,调动次数
		public int major_change_amount { get; set; }
		//bonus_amount smallint null,激励累计次数
		public int bonus_amount { get; set; }
		//training_amount smallint null,培训累计次数
		public int training_amount { get; set; }
		//file_chang_amount smallint null,档案变更累计次数
		public int file_chang_amount { get; set; }
		//human_histroy_records text null,简历
		public string human_histroy_records { get; set; }
		//human_family_membership text null,家庭关系
		public string human_family_membership { get; set; }
		//human_picture varchar(255) null,相片
		public string human_picture { get; set; }
		//attachment_name varchar(255) null,附件名称
		public string attachment_name { get; set; }
		//check_status smallint null,复核状态
		public int check_status { get; set; }
		//register varchar(60) null,档案登记人
		public string register { get; set; }
		//checker varchar(60) null,档案复核人
		public string checker { get; set; }
		//changer varchar(60) null,档案变更人
		public string changer { get; set; }
		//regist_time datetime null,档案登记时间
		public DateTime regist_time { get; set; }
		//check_time datetime null,档案复核时间
		public DateTime check_time { get; set; }
		//change_time datetime null,档案变更时间
		public DateTime change_time { get; set; }
		//lastly_change_time datetime null,档案最近更改时间
		public DateTime lastly_change_time { get; set; }
		//delete_time datetime null,档案删除时间
		public DateTime delete_time { get; set; }
		//recovery_time datetime null,档案恢复时间
		public DateTime recovery_time { get; set; }
		//human_file_status bit null档案状态
		public bool human_file_status { get; set; }
	}
}
