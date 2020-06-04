using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Engage_exam//试卷登记表
	{
		//	exa_id smallint identity not null,主键，自动增长列
		[Key]
		public int exa_id { get; set; }
		//exam_number varchar(30) null,试卷编号
		public string exam_number { get; set; }
		//major_kind_id char (2) null,职位分类编号
		public string major_kind_id { get; set; }
		//major_kind_name varchar(60) null,职位分类名称
		public string major_kind_name { get; set; }
		//major_id char (2) null,职位编号
		public string major_id { get; set; }
		//major_name varchar(60) null,职位名称
		public string major_name { get; set; }
		//register varchar(60) null,登记人
		public string register { get; set; }
		//regist_time datetime null,登记时间
		public DateTime regist_time { get; set; }
		//limite_time smallint null,答题限时
		public int limite_time { get; set; }

	}
}
