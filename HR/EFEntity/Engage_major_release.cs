using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Engage_major_release//职位发表登记表
	{
		//	mre_id smallint identity not null,主键，自动增长列
		[Key]
		public int mre_id { get; set; }
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
		//human_amount smallint null,招聘人数
		public int human_amount { get; set; }
		//engage_type varchar(60) null,招聘类型
		public string engage_type { get; set; }
		//deadline datetime null,截至日期
		public DateTime deadline { get; set; }
		//register varchar(60) null,登记人
		public string register { get; set; }
		//changer varchar(60) null,变更人
		public string changer { get; set; }
		//regist_time datetime null,登记时间
		public DateTime regist_time { get; set; }
		//change_time datetime null,变更时间
		public DateTime change_time { get; set; }
		//major_describe text null,职位描述
		public string major_describe { get; set; }
		//engage_required text null,招聘要求
		public string engage_required { get; set; }
	}
}
