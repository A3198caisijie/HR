using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Engage_interview//面试表
	{
		//	ein_id smallint identity not null,主键，自动增长列
		[Key]
		public int ein_id { get; set; }
		//human_name varchar(60) null,姓名
		public string human_name { get; set; }
		//interview_amount smallint null,面试次数
		public int interview_amount { get; set; }
		//human_major_kind_id char (2) null,职位分类编号
		public string human_major_kind_id { get; set; }
		//human_major_kind_name varchar(30) null,职位分类名称
		public string human_major_kind_name { get; set; }
		//human_major_id char (2) null,职位编号
		public string human_major_id { get; set; }
		//human_major_name varchar(30) null,职位名称
		public string human_major_name { get; set; }
		//image_degree varchar(20) null,形象等级
		public string image_degree { get; set; }
		//native_language_degree varchar(20) null,口才等级
		public string native_language_degree { get; set; }
		//foreign_language_degree varchar(20) null,外语水平等级
		public string foreign_language_degree { get; set; }
		//response_speed_degree varchar(20) null,应变能力
		public string response_speed_degree { get; set; }
		//EQ_degree varchar(20) null,EQ等级 
		public string EQ_degree { get; set; }
		//IQ_degree varchar(20) null,IQ_等级
		public string IQ_degree { get; set; }
		//multi_quality_degree varchar(20) null,综合素质
		public string multi_quality_degree { get; set; }
		//register varchar(60) null,面试人
		public string register { get; set; }
		//checker varchar(60) null,筛选人
		public string checker { get; set; }
		//registe_time datetime null,面试时间
		public DateTime registe_time { get; set; }
		//check_time datetime null,筛选时间
		public DateTime check_time { get; set; }
		//resume_id smallint null,简历编号
		public int resume_id { get; set; }
		//result varchar(20) null,面试结果
		public string result { get; set; }
		//interview_comment text null,面试评价
		public string interview_comment { get; set; }
		//check_comment text null,筛选评价
		public string check_comment { get; set; }
		//interview_status smallint null,面试状态
		public int interview_status { get; set; }
		//check_status smallint null,筛选状态
		public int check_status { get; set; }
	}
}
