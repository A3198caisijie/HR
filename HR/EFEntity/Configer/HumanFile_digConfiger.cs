using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Configer
{
    public class HumanFile_digConfiger: EntityTypeConfiguration<HumanFile_dig>
    {
        public HumanFile_digConfiger()
        {
			this.ToTable(nameof(HumanFile_dig));
			this.Property(e => e.hfd_id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(e => e.human_id).HasMaxLength(30);
			this.Property(e => e.first_kind_id).HasMaxLength(2);
			this.Property(e => e.first_kind_name).HasMaxLength(60);
			this.Property(e => e.second_kind_id).HasMaxLength(2);
			this.Property(e => e.second_kind_name).HasMaxLength(60);
			this.Property(e => e.third_kind_id).HasMaxLength(2);
			this.Property(e => e.third_kind_name).HasMaxLength(60);
			this.Property(e => e.human_name).HasMaxLength(60);
			this.Property(e => e.human_address).HasMaxLength(200);
			this.Property(e => e.human_postcode).HasMaxLength(10);
			this.Property(e => e.human_pro_designation).HasMaxLength(60);
			this.Property(e => e.human_major_kind_id).HasMaxLength(2);
			this.Property(e => e.human_major_kind_name).HasMaxLength(60);
			this.Property(e => e.human_major_id).HasMaxLength(2);
			this.Property(e => e.hunma_major_name).HasMaxLength(60);
			this.Property(e => e.human_telephone).HasMaxLength(20);
			this.Property(e => e.human_mobilephone).HasMaxLength(11);
			this.Property(e => e.human_bank).HasMaxLength(50);
			this.Property(e => e.human_account).HasMaxLength(30);
			this.Property(e => e.human_qq).HasMaxLength(15);
			this.Property(e => e.human_email).HasMaxLength(50);
			this.Property(e => e.human_hobby).HasMaxLength(60);
			this.Property(e => e.human_speciality).HasMaxLength(60);
			this.Property(e => e.human_sex).HasMaxLength(2);
			this.Property(e => e.human_religion).HasMaxLength(50);
			this.Property(e => e.human_party).HasMaxLength(50);
			this.Property(e => e.human_nationality).HasMaxLength(50);
			this.Property(e => e.human_race).HasMaxLength(50);
			this.Property(e => e.human_birthplace).HasMaxLength(50);
			this.Property(e => e.human_educated_degree).HasMaxLength(60);
			this.Property(e => e.human_educated_major).HasMaxLength(60);
			this.Property(e => e.human_society_security_id).HasMaxLength(30);
			this.Property(e => e.human_id_card).HasMaxLength(20);
			this.Property(e => e.remark).HasMaxLength(100);
			this.Property(e => e.salary_standard_id).HasMaxLength(30);
			this.Property(e => e.salary_standard_name).HasMaxLength(60);
			this.Property(e => e.human_histroy_records).HasMaxLength(100);
			this.Property(e => e.human_family_membership).HasMaxLength(100);
			this.Property(e => e.human_picture).HasMaxLength(255);
			this.Property(e => e.attachment_name).HasMaxLength(255);
			this.Property(e => e.register).HasMaxLength(60);
			this.Property(e => e.checker).HasMaxLength(60);
			this.Property(e => e.changer).HasMaxLength(60);
		}
	}
}
