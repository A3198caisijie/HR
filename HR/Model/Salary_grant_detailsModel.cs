using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Salary_grant_detailsModel
	{//	grd_id smallint identity not null,主键，自动增长列 
		public int grd_id { get; set; }
		//salary_grant_id varchar(30) null,薪酬发放编号
		public string salary_grant_id { get; set; }
		//human_id varchar(30) null,档案编号
		public string human_id { get; set; }
		//human_name varchar(60) null,姓名
		public string human_name { get; set; }
		//bouns_sum money null,奖励金额
		public double bouns_sum { get; set; }
		//sale_sum money null,销售绩效金额
		public double sale_sum { get; set; }
		//deduct_sum money null,应扣金额
		public double deduct_sum { get; set; }
		//salary_standard_sum money null,标准薪酬总额
		public double salary_standard_sum { get; set; }
		//salary_paid_sum money null实发薪酬总额
		public double salary_paid_sum { get; set; }
	}
}
