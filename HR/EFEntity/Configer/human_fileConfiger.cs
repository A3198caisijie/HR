using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFEntity.Configer
{
    public class Human_fileConfiger:EntityTypeConfiguration<Human_file>
    {
        public Human_fileConfiger()
        {
            this.ToTable(nameof(Human_file));
            this.Property(e => e.huf_id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
