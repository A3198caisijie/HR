using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
    public class Engage_answer_detailsConfiger:EntityTypeConfiguration<Engage_answer_details>
    {
        public Engage_answer_detailsConfiger()
        {
            this.ToTable(nameof(Engage_answer_details));

        }
    }
}
