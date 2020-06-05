using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using EFEntity;
using Model;
namespace DAO
{
    public class UsersDAO: UsersIDAO
    {
        HRContext hr = new HRContext();
        public List<UsersModel> UsersSelect()
        {
            List<Users> list = hr.Users.ToList();
            List<UsersModel> list2 = new List<UsersModel>();
            foreach (Users item in list)
            {
                UsersModel um = new UsersModel()
                {
                    user_id = item.user_id,
                    user_name = item.user_name,
                    u_password = item.u_password,
                    u_true_name = item.u_true_name
                };
                list2.Add(um);
            }
            return list2;
        }
    }
}
