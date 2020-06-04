using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
    public class Engage_exam_detailsConfiger:EntityTypeConfiguration<Engage_exam_details>
    {
        public Engage_exam_detailsConfiger()
        {
            this.ToTable(nameof(Engage_exam_details));
        }
    }
}
