using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFEntity.Configer
{
    public class config_file_second_kindConfiger:EntityTypeConfiguration<Config_file_second_kind>
    {
        public config_file_second_kindConfiger()
        {
            this.ToTable(nameof(Config_file_second_kind));
            this.Property(e => e.fsk_id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.first_kind_id).HasMaxLength(2);
            this.Property(e => e.first_kind_name).HasMaxLength(60);
            this.Property(e => e.second_kind_id).HasMaxLength(2);
            this.Property(e => e.second_kind_name).HasMaxLength(60);
            this.Property(e => e.second_salary_id).HasMaxLength(100);
            this.Property(e => e.second_sale_id).HasMaxLength(100);
        }
    }
}
