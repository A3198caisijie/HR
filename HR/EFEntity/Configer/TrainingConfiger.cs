using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFEntity.Configer
{
    public class TrainingConfiger:EntityTypeConfiguration<Training>
    {
        public TrainingConfiger()
        {
            this.ToTable(nameof(Training));
        }
    }
}
