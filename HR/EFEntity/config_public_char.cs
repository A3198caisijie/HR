using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Config_public_char//公共字段设置，包括薪酬设置，职称设置，国籍，民族，宗教信仰，政治面貌，教育年限，学历,专业，特长，爱好，培训项目，培训成绩，奖励项目，奖励等级
    {
        //pbc_id : 主键，自动增长列
        //attribute_kind : 属性的种类
        //attribute_name : 属性的名称
        [Key]
        public int pbc_id { get; set; }
        public string attribute_kind { get; set; }
        public string attribute_name { get; set; }

    }
}
