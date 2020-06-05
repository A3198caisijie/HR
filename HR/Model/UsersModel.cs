using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UsersModel
    {
        //user_id : 主键，自动增长列
        //user_name : 用户名
        //user_true_name : 真实姓名 
        //user_password : 密码 
        public int user_id { get; set; }
        [Required(ErrorMessage = "用户名不能为空")]
        public string user_name { get; set; }
        [Required(ErrorMessage = "真实姓名不能为空")]
        public string u_true_name { get; set; }
        [Required(ErrorMessage = "密码不能为空")]
        public string u_password { get; set; }
    }
    
}
