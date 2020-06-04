using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class HRContext:DbContext
    {
        public HRContext():base("name=sql1")
        {
            Database.SetInitializer<HRContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Config_public_char> Config_public_char { get; set; }
        public DbSet<Config_file_first_kind> Config_File_First_Kind { get; set; }
        public DbSet<Config_file_second_kind> Config_File_Second_Kind { get; set; }
        public DbSet<Config_file_third_kind> Config_File_Third_Kind { get; set; }
        public DbSet<Config_question_first_kind> Config_question_first_kind { get; set; }
        public DbSet<Config_question_second_kind> Config_question_second_kind { get; set; }
        public DbSet<Config_primary_key> Config_primary_key { get; set; }
        public DbSet<Config_major_kind> Config_major_kind { get; set; }
        public DbSet<Config_major> Config_major { get; set; }
        public DbSet<Human_file> Human_file { get; set; }
        public DbSet<HumanFile_dig> HumanFile_dig { get; set; }
        public DbSet<Salary_standard_details> Salary_standard_details { get; set; }
        public DbSet<Salary_standard> Salary_standard { get; set; }
        public DbSet<Bonus> Bonus { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Major_change> Major_change { get; set; }
        public DbSet<Salary_grant> Salary_grant { get; set; }
        public DbSet<Salary_grant_details> Salary_grant_details { get; set; }
        public DbSet<Engage_major_release> Engage_major_release { get; set; }
        public DbSet<Engage_exam_details> Engage_exam_details { get; set; }
        public DbSet<Engage_exam> Engage_exam { get; set; }
        public DbSet<Engage_answer> Engage_answer { get; set; }
        public DbSet<Engage_answer_details> Engage_answer_details { get; set; }
        public DbSet<Engage_subjects> Engage_subjects { get; set; }
        public DbSet<Engage_resume> Engage_resume { get; set; }
        public DbSet<Engage_interview> Engage_interview { get; set; }

    }
}
