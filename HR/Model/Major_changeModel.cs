using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Major_changeModel
	{//	mch_id smallint identity not null,主键，自动增长列
		public int mch_id { get; set; }
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
		//major_kind_id char (2) null,职位分类编号
		public string major_kind_id { get; set; }
		//major_kind_name varchar(60) null,职位分类名称
		public string major_kind_name { get; set; }
		//major_id char (2) null,职位编号
		public string major_id { get; set; }
		//major_name varchar(60) null,职位名称
		public string major_name { get; set; }
		//new_first_kind_id char (2) null,新一级机构编号
		public string new_first_kind_id { get; set; }
		//new_first_kind_name varchar(60) null,新一级机构名称
		public string new_first_kind_name { get; set; }
		//new_second_kind_id char (2) null,新二级机构编号
		public string new_second_kind_id { get; set; }
		//new_second_kind_name varchar(60) null,新二级机构名称
		public string new_second_kind_name { get; set; }
		//new_third_kind_id char (2) null,新三级机构编号
		public string new_third_kind_id { get; set; }
		//new_third_kind_name varchar(60) null,新三级机构名称
		public string new_third_kind_name { get; set; }
		//new_major_kind_id char (2) null,新职位分类编号
		public string new_major_kind_id { get; set; }
		//new_major_kind_name varchar(60) null,新职位分类名称
		public string new_major_kind_name { get; set; }
		//new_major_id char (2) null,新职位编号
		public string new_major_id { get; set; }
		//new_major_name varchar(60) null,新职位名称
		public string new_major_name { get; set; }
		//human_id varchar(30) null,人力资源档案编号
		public string human_id { get; set; }
		//human_name varchar(60) null,姓名
		public string human_name { get; set; }
		//salary_standard_id varchar(30) null,薪酬标准编号
		public string salary_standard_id { get; set; }
		//salary_standard_name varchar(60) null,薪酬标准名称
		public string salary_standard_name { get; set; }
		//salary_sum money null,薪酬总额
		public double salary_sum { get; set; }
		//new_salary_standard_id varchar(30) null,新薪酬标准编号
		public string new_salary_standard_id { get; set; }
		//new_salary_standard_name varchar(60) null,新薪酬标准名称
		public string new_salary_standard_name { get; set; }
		//new_salary_sum money null,新薪酬总额
		public double new_salary_sum { get; set; }
		//change_reason text null,调动原因
		public string change_reason { get; set; }
		//check_reason text null,审核通过意见
		public string check_reason { get; set; }
		//check_status smallint null,复核通过状态
		public int check_status { get; set; }
		//register varchar(60) null,登记人
		public string register { get; set; }
		//checker varchar(60) null,复核人
		public string checker { get; set; }
		//regist_time datetime null,登记时间
		public DateTime regist_time { get; set; }
		//check_time datetime null,复核时间
		public DateTime check_time { get; set; }
	}
}
