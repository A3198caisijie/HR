using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAO;
using Model;
namespace BLL
{
    public class Salary_standardBLL:Salary_standardIBLL
    {
        public Salary_standardIDAO ssid { get; set; }

        public int Salary_standardUpdate(Salary_standardModel ssm)
        {
            return ssid.Salary_standardUpdate(ssm);
        }
    }
}
