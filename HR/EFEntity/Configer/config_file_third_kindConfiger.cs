using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Configer
{
    public class Config_file_third_kindConfiger:EntityTypeConfiguration<Config_file_third_kind>
    {
        public Config_file_third_kindConfiger()
        {
            this.ToTable(nameof(Config_file_third_kind));
            this.Property(e => e.ftk_id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.first_kind_id).HasMaxLength(2);
            this.Property(e => e.first_kind_name).HasMaxLength(60);
            this.Property(e => e.second_kind_id).HasMaxLength(2);
            this.Property(e => e.second_kind_name).HasMaxLength(60);
            this.Property(e => e.third_kind_id).HasMaxLength(2);
            this.Property(e => e.third_kind_name).HasMaxLength(60);
            this.Property(e => e.third_kind_sale_id).HasMaxLength(100);
            this.Property(e=>e.third_kind_is_retail).HasMaxLength(100);
        }

    }
}
