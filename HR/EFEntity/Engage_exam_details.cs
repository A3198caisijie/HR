using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Engage_exam_details//试卷详细信息
	{
		//	exd_id smallint identity not null,主键，自动增长列
		[Key]
		public int exd_id { get; set; }
		//exam_number varchar(30) null,//试卷编号
		public string exam_number { get; set; }
		//first_kind_id char (2) null,//试题一级分类编号
		public string first_kind_id { get; set; }
		//first_kind_name varchar(60) null,//试题一级分类名称
		public string first_kind_name { get; set; }
		//second_kind_id char (2) null,试题二级分类编号
		public string second_kind_id { get; set; }
		//second_kind_name varchar(60) null,试题二级分类名称
		public string second_kind_name { get; set; }
		//question_amount smallint null出题数量
		public int question_amount { get; set; }


	}
}
