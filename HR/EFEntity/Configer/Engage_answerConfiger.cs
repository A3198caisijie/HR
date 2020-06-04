using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
    public class Engage_answerConfiger:EntityTypeConfiguration<Engage_answer>
    {
        public Engage_answerConfiger()
        {
            this.ToTable(nameof(Engage_answer));
        }
    }
}
