using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
    public class Engage_resumeConfiger:EntityTypeConfiguration<Engage_resume>
    {
        public Engage_resumeConfiger()
        {
            this.ToTable(nameof(Engage_resume));
        }
    }
}
