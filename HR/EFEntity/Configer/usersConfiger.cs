using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFEntity.Configer
{
    public class UsersConfiger : EntityTypeConfiguration<Users>
    {
        public UsersConfiger()
        {
            this.ToTable(nameof(Users));
            this.Property(e => e.user_id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.user_name).HasMaxLength(60);
            this.Property(e => e.u_password).HasMaxLength(60);
            this.Property(e => e.u_true_name).HasMaxLength(60);

        }
    }
}
