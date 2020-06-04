using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
    public class Engage_major_releaseConfiger:EntityTypeConfiguration<Engage_major_release>
    {
        public Engage_major_releaseConfiger()
        {
            this.ToTable(nameof(Engage_major_release));
        }
    }
}
