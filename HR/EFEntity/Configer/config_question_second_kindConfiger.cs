using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Configer
{
    public class Config_question_second_kindConfiger:EntityTypeConfiguration<Config_question_second_kind>
    {
        public Config_question_second_kindConfiger()
        {
            this.ToTable(nameof(Config_question_second_kind));
            this.Property(e => e.qsk_id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.first_kind_id).HasMaxLength(2);
            this.Property(e => e.first_kind_name).HasMaxLength(60);
            this.Property(e => e.second_kind_id).HasMaxLength(2);
            this.Property(e => e.second_kind_name).HasMaxLength(60);
        }
    }
}
