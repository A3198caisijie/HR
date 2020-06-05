using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Config_public_charModel
    {//pbc_id : 主键，自动增长列
        //attribute_kind : 属性的种类
        //attribute_name : 属性的名称
        public int pbc_id { get; set; }
        public string attribute_kind { get; set; }
        public string attribute_name { get; set; }
    }
}
