using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
    public class Salary_grantConfiger:EntityTypeConfiguration<Salary_grant>
    {
        public Salary_grantConfiger()
        {
            this.ToTable(nameof(Salary_grant));
        }
    }
}
