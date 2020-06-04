using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Engage_answer//考试答题登记表
	{
		//	ans_id smallint identity not null,主键，自动增长列
		[Key]
		public int ans_id { get; set; }
		//answer_number varchar(30) null,答案编号
		public string answer_number { get; set; }
		//exam_number varchar(30) null,试卷编号
		public string exam_number { get; set; }
		//resume_id smallint null,简历编号
		public int resume_id { get; set; }
		//interview_id smallint null,面试编号
		public int interview_id { get; set; }
		//human_name varchar(60) null,姓名
		public string human_name { get; set; }
		//human_idcard varchar(30) null,身份证号
		public string human_idcard { get; set; }
		//major_kind_id char (2) null,职位分类编号
		public string major_kind_id { get; set; }
		//major_kind_name char (10) null,major_kind_name 属于 engage_answer
		public string major_kind_name { get; set; }
		//major_id char (10) null,major_id 属于 engage_answer
		public string major_id { get; set; }
		//major_name char (10) null,major_name 属于 engage_answer
		public string major_name { get; set; }
		//test_time datetime null,测试时间
		public DateTime test_time { get; set; }
		//use_time varchar(20) null,use_time 属于 engage_answer
		public string use_time { get; set; }
		//total_point numeric(5,2) null,总分
		public double total_point { get; set; }

	}
}
