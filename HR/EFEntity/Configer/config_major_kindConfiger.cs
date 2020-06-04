using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Configer
{
    public class Config_major_kindConfiger:EntityTypeConfiguration<Config_major_kind>
    {
        public Config_major_kindConfiger()
        {
            this.ToTable(nameof(Config_major_kind));
            this.Property(e => e.mfk_id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.major_kind_id).HasMaxLength(2);
            this.Property(e => e.major_kind_name).HasMaxLength(60);
        }
    }
}
