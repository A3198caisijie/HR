using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using IBLL;
using Model;
namespace BLL
{
    public class UsersBLL:UsersIBLL
    {
        public UsersIDAO ui { get; set; }
        public List<UsersModel> UsersSelect()
        {
            return  ui.UsersSelect();
        }
    }
}
