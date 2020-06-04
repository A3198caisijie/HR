using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Configer
{
    public class Config_file_first_kindConfiger : EntityTypeConfiguration<Config_file_first_kind>
    {
        public Config_file_first_kindConfiger()
        {
            this.ToTable(nameof(Config_file_first_kind));
            this.Property(e => e.ffk_id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.first_kind_id).HasMaxLength(2);
            this.Property(e => e.first_kind_name).HasMaxLength(60);
            this.Property(e => e.first_kind_salary_id).HasMaxLength(100);
            this.Property(e => e.first_kind_sale_id).HasMaxLength(100);
        }
    }
}
