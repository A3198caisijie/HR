using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Users//用户表
    {
        //user_id : 主键，自动增长列
        //user_name : 用户名
        //user_true_name : 真实姓名 
        //user_password : 密码 
        [Key]
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string u_true_name { get; set; }
        public string u_password { get; set; }

    }
}
