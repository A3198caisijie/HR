using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Engage_subjectsModel
	{//	sub_id smallint identity not null, 主键，自动增长列
		public int sub_id { get; set; }
		//first_kind_id char (2) null,试题I级分类编号
		public string first_kind_id { get; set; }
		//first_kind_name varchar(60) null,试题I级分类名称
		public string first_kind_name { get; set; }
		//second_kind_id char (2) null,试题II级分类编号
		public string second_kind_id { get; set; }
		//second_kind_name varchar(60) null,试题II级分类名称
		public string second_kind_name { get; set; }
		//register varchar(60) null,登记人
		public string register { get; set; }
		//regist_time datetime null,登记时间
		public DateTime regist_time { get; set; }
		//derivation varchar(60) null,试题出处
		public string derivation { get; set; }
		//content text null,题干
		public string content { get; set; }
		//key_a text null,答案a 
		public string key_a { get; set; }
		//key_b text null,答案b 
		public string key_b { get; set; }
		//key_c text null,答案c 
		public string key_c { get; set; }
		//key_d text null,答案d
		public string key_d { get; set; }
		//key_e text null,答案e 
		public string key_e { get; set; }
		//correct_key varchar(10) null,正确答案
		public string correct_key { get; set; }
		//changer varchar(60) null,变更人
		public string changer { get; set; }
		//change_time datetime null,变更时间
		public DateTime change_time { get; set; }
	}
}
