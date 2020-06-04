using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Configer
{
    public class Config_primary_keyConfiger:EntityTypeConfiguration<Config_primary_key>
    {
        public Config_primary_keyConfiger()
        {
            this.ToTable(nameof(Config_primary_key));
            this.Property(e => e.prk_id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.primary_key_table).HasMaxLength(50);
            this.Property(e => e.primary_key).HasMaxLength(60);
            this.Property(e => e.key_name).HasMaxLength(60);
        }
    }
}
