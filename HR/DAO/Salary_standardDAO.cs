using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAO;
using EFEntity;
namespace DAO
{
    public class Salary_standardDAO:Salary_standardIDAO
    {
        HRContext hr = new HRContext();
        public int Salary_standardUpdate(Salary_standardModel ssm)
        {
                Salary_standard ss = new Salary_standard()
                {
                    ssd_id = ssm.ssd_id,
                    standard_id= ssm.standard_id,
                    standard_name= ssm.standard_name,
                    designer = ssm.designer,
                    register = ssm.register,
                    checker = ssm.checker,
                    changer = ssm.changer,
                    regist_time = ssm.regist_time,
                    check_time = ssm.check_time,
                    change_time = ssm.change_time,
                    salary_sum = ssm.salary_sum,
                    check_status = ssm.check_status,
                    change_status = ssm.change_status,
                    check_comment = ssm.check_comment,
                    remark = ssm.remark,
                };
            hr.Salary_standard.Attach(ss);
            hr.Entry(ss).State = System.Data.Entity.EntityState.Modified;
            return hr.SaveChanges();
        }
    }
}
