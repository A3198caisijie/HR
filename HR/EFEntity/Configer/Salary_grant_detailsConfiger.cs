using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
    public class Salary_grant_detailsConfiger:EntityTypeConfiguration<Salary_grant_details>
    {
        public Salary_grant_detailsConfiger()
        {
            this.ToTable(nameof(Salary_grant_details));
        }
    }
}
