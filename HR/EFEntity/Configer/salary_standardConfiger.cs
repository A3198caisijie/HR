using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
    public class Salary_standardConfiger:EntityTypeConfiguration<Salary_standard>
    {
        public Salary_standardConfiger()
        {
            this.ToTable(nameof(Salary_standard));
        }
    }
}
