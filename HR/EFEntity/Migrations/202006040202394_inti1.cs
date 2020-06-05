namespace EFEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inti1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bonus",
                c => new
                    {
                        bon_id = c.Int(nullable: false, identity: true),
                        major_kind_id = c.String(),
                        major_kind_name = c.String(),
                        major_id = c.String(),
                        major_name = c.String(),
                        human_id = c.String(),
                        human_name = c.String(),
                        bonus_item = c.String(),
                        bonus_worth = c.String(),
                        bonus_degree = c.String(),
                        remark = c.String(),
                        register = c.String(),
                        checker = c.String(),
                        regist_time = c.DateTime(nullable: false),
                        check_time = c.DateTime(nullable: false),
                        check_status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.bon_id);
            
            CreateTable(
                "dbo.Config_file_first_kind",
                c => new
                    {
                        ffk_id = c.Int(nullable: false, identity: true),
                        first_kind_id = c.String(maxLength: 2),
                        first_kind_name = c.String(maxLength: 60),
                        first_kind_salary_id = c.String(maxLength: 100),
                        first_kind_sale_id = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ffk_id);
            
            CreateTable(
                "dbo.Config_file_second_kind",
                c => new
                    {
                        fsk_id = c.Int(nullable: false, identity: true),
                        first_kind_id = c.String(maxLength: 2),
                        first_kind_name = c.String(maxLength: 60),
                        second_kind_id = c.String(maxLength: 2),
                        second_kind_name = c.String(maxLength: 60),
                        second_salary_id = c.String(maxLength: 100),
                        second_sale_id = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.fsk_id);
            
            CreateTable(
                "dbo.Config_file_third_kind",
                c => new
                    {
                        ftk_id = c.Int(nullable: false, identity: true),
                        first_kind_id = c.String(maxLength: 2),
                        first_kind_name = c.String(maxLength: 60),
                        second_kind_id = c.String(maxLength: 2),
                        second_kind_name = c.String(maxLength: 60),
                        third_kind_id = c.String(maxLength: 2),
                        third_kind_name = c.String(maxLength: 60),
                        third_kind_sale_id = c.String(maxLength: 100),
                        third_kind_is_retail = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ftk_id);
            
            CreateTable(
                "dbo.Config_major",
                c => new
                    {
                        mak_id = c.Int(nullable: false, identity: true),
                        major_kind_id = c.String(maxLength: 2),
                        major_kind_name = c.String(maxLength: 60),
                        major_id = c.String(maxLength: 2),
                        major_name = c.String(maxLength: 60),
                        test_amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.mak_id);
            
            CreateTable(
                "dbo.Config_major_kind",
                c => new
                    {
                        mfk_id = c.Int(nullable: false, identity: true),
                        major_kind_id = c.String(maxLength: 2),
                        major_kind_name = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.mfk_id);
            
            CreateTable(
                "dbo.Config_primary_key",
                c => new
                    {
                        prk_id = c.Int(nullable: false, identity: true),
                        primary_key_table = c.String(maxLength: 50),
                        primary_key = c.String(maxLength: 60),
                        key_name = c.String(maxLength: 60),
                        primary_key_status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.prk_id);
            
            CreateTable(
                "dbo.Config_public_char",
                c => new
                    {
                        pbc_id = c.Int(nullable: false, identity: true),
                        attribute_kind = c.String(maxLength: 60),
                        attribute_name = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.pbc_id);
            
            CreateTable(
                "dbo.Config_question_first_kind",
                c => new
                    {
                        qfk_id = c.Int(nullable: false, identity: true),
                        first_kind_id = c.String(maxLength: 2),
                        first_kind_name = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.qfk_id);
            
            CreateTable(
                "dbo.Config_question_second_kind",
                c => new
                    {
                        qsk_id = c.Int(nullable: false, identity: true),
                        first_kind_id = c.String(maxLength: 2),
                        first_kind_name = c.String(maxLength: 60),
                        second_kind_id = c.String(maxLength: 2),
                        second_kind_name = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.qsk_id);
            
            CreateTable(
                "dbo.Engage_answer",
                c => new
                    {
                        ans_id = c.Int(nullable: false, identity: true),
                        answer_number = c.String(),
                        exam_number = c.String(),
                        resume_id = c.Int(nullable: false),
                        interview_id = c.Int(nullable: false),
                        human_name = c.String(),
                        human_idcard = c.String(),
                        major_kind_id = c.String(),
                        major_kind_name = c.String(),
                        major_id = c.String(),
                        major_name = c.String(),
                        test_time = c.DateTime(nullable: false),
                        use_time = c.String(),
                        total_point = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ans_id);
            
            CreateTable(
                "dbo.Engage_answer_details",
                c => new
                    {
                        and_id = c.Int(nullable: false, identity: true),
                        answer_number = c.String(),
                        subject_id = c.Int(nullable: false),
                        answer = c.String(),
                    })
                .PrimaryKey(t => t.and_id);
            
            CreateTable(
                "dbo.Engage_exam",
                c => new
                    {
                        exa_id = c.Int(nullable: false, identity: true),
                        exam_number = c.String(),
                        major_kind_id = c.String(),
                        major_kind_name = c.String(),
                        major_id = c.String(),
                        major_name = c.String(),
                        register = c.String(),
                        regist_time = c.DateTime(nullable: false),
                        limite_time = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.exa_id);
            
            CreateTable(
                "dbo.Engage_exam_details",
                c => new
                    {
                        exd_id = c.Int(nullable: false, identity: true),
                        exam_number = c.String(),
                        first_kind_id = c.String(),
                        first_kind_name = c.String(),
                        second_kind_id = c.String(),
                        second_kind_name = c.String(),
                        question_amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.exd_id);
            
            CreateTable(
                "dbo.Engage_interview",
                c => new
                    {
                        ein_id = c.Int(nullable: false, identity: true),
                        human_name = c.String(),
                        interview_amount = c.Int(nullable: false),
                        human_major_kind_id = c.String(),
                        human_major_kind_name = c.String(),
                        human_major_id = c.String(),
                        human_major_name = c.String(),
                        image_degree = c.String(),
                        native_language_degree = c.String(),
                        foreign_language_degree = c.String(),
                        response_speed_degree = c.String(),
                        EQ_degree = c.String(),
                        IQ_degree = c.String(),
                        multi_quality_degree = c.String(),
                        register = c.String(),
                        checker = c.String(),
                        registe_time = c.DateTime(nullable: false),
                        check_time = c.DateTime(nullable: false),
                        resume_id = c.Int(nullable: false),
                        result = c.String(),
                        interview_comment = c.String(),
                        check_comment = c.String(),
                        interview_status = c.Int(nullable: false),
                        check_status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ein_id);
            
            CreateTable(
                "dbo.Engage_major_release",
                c => new
                    {
                        mre_id = c.Int(nullable: false, identity: true),
                        first_kind_id = c.String(),
                        first_kind_name = c.String(),
                        second_kind_id = c.String(),
                        second_kind_name = c.String(),
                        third_kind_id = c.String(),
                        third_kind_name = c.String(),
                        major_kind_id = c.String(),
                        major_kind_name = c.String(),
                        major_id = c.String(),
                        major_name = c.String(),
                        human_amount = c.Int(nullable: false),
                        engage_type = c.String(),
                        deadline = c.DateTime(nullable: false),
                        register = c.String(),
                        changer = c.String(),
                        regist_time = c.DateTime(nullable: false),
                        change_time = c.DateTime(nullable: false),
                        major_describe = c.String(),
                        engage_required = c.String(),
                    })
                .PrimaryKey(t => t.mre_id);
            
            CreateTable(
                "dbo.Engage_resume",
                c => new
                    {
                        res_id = c.Int(nullable: false, identity: true),
                        human_name = c.String(),
                        engage_type = c.String(),
                        human_address = c.String(),
                        human_postcode = c.String(),
                        human_major_kind_id = c.String(),
                        human_major_kind_name = c.String(),
                        human_major_id = c.String(),
                        human_major_name = c.String(),
                        human_telephone = c.String(),
                        human_homephone = c.String(),
                        human_mobilephone = c.String(),
                        human_email = c.String(),
                        human_hobby = c.String(),
                        human_specility = c.String(),
                        human_sex = c.String(),
                        human_religion = c.String(),
                        human_party = c.String(),
                        human_nationality = c.String(),
                        human_race = c.String(),
                        human_birthday = c.DateTime(nullable: false),
                        human_age = c.Int(nullable: false),
                        human_educated_degree = c.String(),
                        human_educated_years = c.Int(nullable: false),
                        human_educated_major = c.String(),
                        human_college = c.String(),
                        human_idcard = c.String(),
                        human_birthplace = c.String(),
                        demand_salary_standard = c.Double(nullable: false),
                        human_history_records = c.String(),
                        remark = c.String(),
                        recomandation = c.String(),
                        human_picture = c.String(),
                        attachment_name = c.String(),
                        check_status = c.Int(nullable: false),
                        register = c.String(),
                        regist_time = c.DateTime(nullable: false),
                        checker = c.String(),
                        check_time = c.DateTime(nullable: false),
                        interview_status = c.Int(nullable: false),
                        total_points = c.String(),
                        test_amount = c.Int(nullable: false),
                        test_checker = c.String(),
                        test_check_time = c.DateTime(nullable: false),
                        pass_register = c.String(),
                        pass_regist_time = c.DateTime(nullable: false),
                        pass_checker = c.String(),
                        pass_check_time = c.DateTime(nullable: false),
                        pass_check_status = c.Int(nullable: false),
                        pass_checkComment = c.String(),
                        pass_passComment = c.String(),
                    })
                .PrimaryKey(t => t.res_id);
            
            CreateTable(
                "dbo.Engage_subjects",
                c => new
                    {
                        sub_id = c.Int(nullable: false, identity: true),
                        first_kind_id = c.String(),
                        first_kind_name = c.String(),
                        second_kind_id = c.String(),
                        second_kind_name = c.String(),
                        register = c.String(),
                        regist_time = c.DateTime(nullable: false),
                        derivation = c.String(),
                        content = c.String(),
                        key_a = c.String(),
                        key_b = c.String(),
                        key_c = c.String(),
                        key_d = c.String(),
                        key_e = c.String(),
                        correct_key = c.String(),
                        changer = c.String(),
                        change_time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.sub_id);
            
            CreateTable(
                "dbo.Human_file",
                c => new
                    {
                        huf_id = c.Int(nullable: false, identity: true),
                        human_id = c.String(),
                        first_kind_id = c.String(),
                        first_kind_name = c.String(),
                        second_kind_id = c.String(),
                        second_kind_name = c.String(),
                        third_kind_id = c.String(),
                        third_kind_name = c.String(),
                        human_name = c.String(),
                        human_address = c.String(),
                        human_postcode = c.String(),
                        human_pro_designation = c.String(),
                        human_major_kind_id = c.String(),
                        human_major_kind_name = c.String(),
                        human_major_id = c.String(),
                        hunma_major_name = c.String(),
                        human_telephone = c.String(),
                        human_mobilephone = c.String(),
                        human_bank = c.String(),
                        human_account = c.String(),
                        human_qq = c.String(),
                        human_email = c.String(),
                        human_hobby = c.String(),
                        human_speciality = c.String(),
                        human_sex = c.String(),
                        human_religion = c.String(),
                        human_party = c.String(),
                        human_nationality = c.String(),
                        human_race = c.String(),
                        human_birthday = c.DateTime(nullable: false),
                        human_birthplace = c.String(),
                        human_age = c.Int(nullable: false),
                        human_educated_degree = c.String(),
                        human_educated_years = c.Int(nullable: false),
                        human_educated_major = c.String(),
                        human_society_security_id = c.String(),
                        human_id_card = c.String(),
                        v = c.String(),
                        salary_standard_id = c.String(),
                        salary_standard_name = c.String(),
                        salary_sum = c.Double(nullable: false),
                        demand_salaray_sum = c.Double(nullable: false),
                        paid_salary_sum = c.Double(nullable: false),
                        major_change_amount = c.Int(nullable: false),
                        bonus_amount = c.Int(nullable: false),
                        training_amount = c.Int(nullable: false),
                        file_chang_amount = c.Int(nullable: false),
                        human_histroy_records = c.String(),
                        human_family_membership = c.String(),
                        human_picture = c.String(),
                        attachment_name = c.String(),
                        check_status = c.Int(nullable: false),
                        register = c.String(),
                        checker = c.String(),
                        changer = c.String(),
                        regist_time = c.DateTime(nullable: false),
                        check_time = c.DateTime(nullable: false),
                        change_time = c.DateTime(nullable: false),
                        lastly_change_time = c.DateTime(nullable: false),
                        delete_time = c.DateTime(nullable: false),
                        recovery_time = c.DateTime(nullable: false),
                        human_file_status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.huf_id);
            
            CreateTable(
                "dbo.HumanFile_dig",
                c => new
                    {
                        hfd_id = c.Int(nullable: false, identity: true),
                        human_id = c.String(maxLength: 30),
                        first_kind_id = c.String(maxLength: 2),
                        first_kind_name = c.String(maxLength: 60),
                        second_kind_id = c.String(maxLength: 2),
                        second_kind_name = c.String(maxLength: 60),
                        third_kind_id = c.String(maxLength: 2),
                        third_kind_name = c.String(maxLength: 60),
                        human_name = c.String(maxLength: 60),
                        human_address = c.String(maxLength: 200),
                        human_postcode = c.String(maxLength: 10),
                        human_pro_designation = c.String(maxLength: 60),
                        human_major_kind_id = c.String(maxLength: 2),
                        human_major_kind_name = c.String(maxLength: 60),
                        human_major_id = c.String(maxLength: 2),
                        hunma_major_name = c.String(maxLength: 60),
                        human_telephone = c.String(maxLength: 20),
                        human_mobilephone = c.String(maxLength: 11),
                        human_bank = c.String(maxLength: 50),
                        human_account = c.String(maxLength: 30),
                        human_qq = c.String(maxLength: 15),
                        human_email = c.String(maxLength: 50),
                        human_hobby = c.String(maxLength: 60),
                        human_speciality = c.String(maxLength: 60),
                        human_sex = c.String(maxLength: 2),
                        human_religion = c.String(maxLength: 50),
                        human_party = c.String(maxLength: 50),
                        human_nationality = c.String(maxLength: 50),
                        human_race = c.String(maxLength: 50),
                        human_birthday = c.DateTime(nullable: false),
                        human_birthplace = c.String(maxLength: 50),
                        human_age = c.Int(nullable: false),
                        human_educated_degree = c.String(maxLength: 60),
                        human_educated_years = c.Int(nullable: false),
                        human_educated_major = c.String(maxLength: 60),
                        human_society_security_id = c.String(maxLength: 30),
                        human_id_card = c.String(maxLength: 20),
                        remark = c.String(maxLength: 100),
                        salary_standard_id = c.String(maxLength: 30),
                        salary_standard_name = c.String(maxLength: 60),
                        salary_sum = c.Double(nullable: false),
                        demand_salaray_sum = c.Double(nullable: false),
                        paid_salary_sum = c.Double(nullable: false),
                        major_change_amount = c.Int(nullable: false),
                        bonus_amount = c.Int(nullable: false),
                        training_amount = c.Int(nullable: false),
                        file_chang_amount = c.Int(nullable: false),
                        human_histroy_records = c.String(maxLength: 100),
                        human_family_membership = c.String(maxLength: 100),
                        human_picture = c.String(maxLength: 255),
                        attachment_name = c.String(maxLength: 255),
                        check_status = c.Int(nullable: false),
                        register = c.String(maxLength: 60),
                        checker = c.String(maxLength: 60),
                        changer = c.String(maxLength: 60),
                        regist_time = c.DateTime(nullable: false),
                        check_time = c.DateTime(nullable: false),
                        change_time = c.DateTime(nullable: false),
                        lastly_change_time = c.DateTime(nullable: false),
                        delete_time = c.DateTime(nullable: false),
                        recovery_time = c.DateTime(nullable: false),
                        human_file_status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.hfd_id);
            
            CreateTable(
                "dbo.Major_change",
                c => new
                    {
                        mch_id = c.Int(nullable: false, identity: true),
                        first_kind_id = c.String(),
                        first_kind_name = c.String(),
                        second_kind_id = c.String(),
                        second_kind_name = c.String(),
                        third_kind_id = c.String(),
                        third_kind_name = c.String(),
                        major_kind_id = c.String(),
                        major_kind_name = c.String(),
                        major_id = c.String(),
                        major_name = c.String(),
                        new_first_kind_id = c.String(),
                        new_first_kind_name = c.String(),
                        new_second_kind_id = c.String(),
                        new_second_kind_name = c.String(),
                        new_third_kind_id = c.String(),
                        new_third_kind_name = c.String(),
                        new_major_kind_id = c.String(),
                        new_major_kind_name = c.String(),
                        new_major_id = c.String(),
                        new_major_name = c.String(),
                        human_id = c.String(),
                        human_name = c.String(),
                        salary_standard_id = c.String(),
                        salary_standard_name = c.String(),
                        salary_sum = c.Double(nullable: false),
                        new_salary_standard_id = c.String(),
                        new_salary_standard_name = c.String(),
                        new_salary_sum = c.Double(nullable: false),
                        change_reason = c.String(),
                        check_reason = c.String(),
                        check_status = c.Int(nullable: false),
                        register = c.String(),
                        checker = c.String(),
                        regist_time = c.DateTime(nullable: false),
                        check_time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.mch_id);
            
            CreateTable(
                "dbo.Salary_grant",
                c => new
                    {
                        sgr_id = c.Int(nullable: false, identity: true),
                        salary_grant_id = c.String(),
                        salary_standard_id = c.String(),
                        first_kind_id = c.String(),
                        first_kind_name = c.String(),
                        second_kind_id = c.String(),
                        second_kind_name = c.String(),
                        third_kind_id = c.String(),
                        third_kind_name = c.String(),
                        human_amount = c.Int(nullable: false),
                        salary_standard_sum = c.Double(nullable: false),
                        salary_paid_sum = c.Double(nullable: false),
                        register = c.String(),
                        regist_time = c.DateTime(nullable: false),
                        checker = c.String(),
                        check_time = c.DateTime(nullable: false),
                        check_status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.sgr_id);
            
            CreateTable(
                "dbo.Salary_grant_details",
                c => new
                    {
                        grd_id = c.Int(nullable: false, identity: true),
                        salary_grant_id = c.String(),
                        human_id = c.String(),
                        human_name = c.String(),
                        bouns_sum = c.Double(nullable: false),
                        sale_sum = c.Double(nullable: false),
                        deduct_sum = c.Double(nullable: false),
                        salary_standard_sum = c.Double(nullable: false),
                        salary_paid_sum = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.grd_id);
            
            CreateTable(
                "dbo.Salary_standard",
                c => new
                    {
                        ssd_id = c.Int(nullable: false, identity: true),
                        standard_id = c.String(),
                        standard_name = c.String(),
                        designer = c.String(),
                        register = c.String(),
                        checker = c.String(),
                        changer = c.String(),
                        regist_time = c.DateTime(nullable: false),
                        check_time = c.DateTime(nullable: false),
                        change_time = c.DateTime(nullable: false),
                        salary_sum = c.Double(nullable: false),
                        check_status = c.Int(nullable: false),
                        change_status = c.Int(nullable: false),
                        check_comment = c.String(),
                        remark = c.String(),
                    })
                .PrimaryKey(t => t.ssd_id);
            
            CreateTable(
                "dbo.Salary_standard_details",
                c => new
                    {
                        sdt_id = c.Int(nullable: false, identity: true),
                        standard_id = c.String(),
                        standard_name = c.String(),
                        item_id = c.Int(nullable: false),
                        item_name = c.String(),
                        salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.sdt_id);
            
            CreateTable(
                "dbo.Training",
                c => new
                    {
                        tra_id = c.Int(nullable: false, identity: true),
                        major_kind_id = c.String(),
                        major_kind_name = c.String(),
                        major_id = c.String(),
                        major_name = c.String(),
                        human_id = c.String(),
                        human_name = c.String(),
                        training_item = c.String(),
                        training_time = c.DateTime(nullable: false),
                        training_hour = c.Int(nullable: false),
                        training_degree = c.String(),
                        register = c.String(),
                        checker = c.String(),
                        regist_time = c.DateTime(nullable: false),
                        check_time = c.DateTime(nullable: false),
                        checkstatus = c.Int(nullable: false),
                        remark = c.String(),
                    })
                .PrimaryKey(t => t.tra_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        user_id = c.Int(nullable: false, identity: true),
                        user_name = c.String(maxLength: 60),
                        u_true_name = c.String(maxLength: 60),
                        u_password = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Training");
            DropTable("dbo.Salary_standard_details");
            DropTable("dbo.Salary_standard");
            DropTable("dbo.Salary_grant_details");
            DropTable("dbo.Salary_grant");
            DropTable("dbo.Major_change");
            DropTable("dbo.HumanFile_dig");
            DropTable("dbo.Human_file");
            DropTable("dbo.Engage_subjects");
            DropTable("dbo.Engage_resume");
            DropTable("dbo.Engage_major_release");
            DropTable("dbo.Engage_interview");
            DropTable("dbo.Engage_exam_details");
            DropTable("dbo.Engage_exam");
            DropTable("dbo.Engage_answer_details");
            DropTable("dbo.Engage_answer");
            DropTable("dbo.Config_question_second_kind");
            DropTable("dbo.Config_question_first_kind");
            DropTable("dbo.Config_public_char");
            DropTable("dbo.Config_primary_key");
            DropTable("dbo.Config_major_kind");
            DropTable("dbo.Config_major");
            DropTable("dbo.Config_file_third_kind");
            DropTable("dbo.Config_file_second_kind");
            DropTable("dbo.Config_file_first_kind");
            DropTable("dbo.Bonus");
        }
    }
}
