using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Configer
{
    public class Config_public_charConfiger:EntityTypeConfiguration<Config_public_char>
    {
        public Config_public_charConfiger()
        {
            this.ToTable(nameof(Config_public_char));
            this.Property(e => e.pbc_id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.attribute_kind).HasMaxLength(60);
            this.Property(e => e.attribute_name).HasMaxLength(60);
        }
    }
}
