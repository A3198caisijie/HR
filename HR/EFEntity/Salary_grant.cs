using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Salary_grant//薪酬发放登记表
	{
		//	sgr_id smallint identity not null,主键，自动增长列
		[Key]
		public int sgr_id { get; set; }
		//salary_grant_id varchar(30) null,薪酬发放编号
		public string salary_grant_id { get; set; }
		//salary_standard_id varchar(30) null,薪酬标准单编号
		public string salary_standard_id { get; set; }
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
		//human_amount smallint null,总人数
		public int human_amount { get; set; }
		//salary_standard_sum money null,标准薪酬总金额
		public double salary_standard_sum { get; set; }
		//salary_paid_sum money null,实发总金额
		public double salary_paid_sum { get; set; }
		//register varchar(60) null,登记人
		public string register { get; set; }
		//regist_time datetime null,登记时间
		public DateTime regist_time { get; set; }
		//checker varchar(60) null,复核人
		public string checker { get; set; }
		//check_time datetime null,复核时间
		public DateTime check_time { get; set; }
		//check_status smallint null复核状态
		public int check_status { get; set; }
	}
}
