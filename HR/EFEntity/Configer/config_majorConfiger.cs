using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Configer
{
    public class Config_majorConfiger:EntityTypeConfiguration<Config_major>
    {
        public Config_majorConfiger()
        {
            this.ToTable(nameof(Config_major));
            this.Property(e => e.mak_id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.major_kind_id).HasMaxLength(2);
            this.Property(e => e.major_kind_name).HasMaxLength(60);
            this.Property(e => e.major_id).HasMaxLength(2);
            this.Property(e => e.major_name).HasMaxLength(60);
        }
    }
}
