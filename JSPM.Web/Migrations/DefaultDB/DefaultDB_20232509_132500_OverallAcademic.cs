using FluentMigrator;

namespace JSPM.Migrations.DefaultDB
{
    [Migration(20232509_132500)]
    public class DefaultDB_20232509_132500_OverallAcademic: AutoReversingMigration
    {

        public override void Up()
        {
            Create.Table("Academic").InSchema("Students")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("CourseLevel").AsString(50).Nullable()
                 .WithColumn("CourseName").AsString(50).Nullable()
                 .WithColumn("YearOfPassing").AsString(50).Nullable()
                 .WithColumn("Percentage").AsString(50).Nullable()
                 .WithColumn("Remark").AsString(50).Nullable()
                 .WithColumn("PassingType").AsString(50).Nullable()
                 .WithColumn("ProjectId").AsInt32().Nullable().ForeignKey("FK_Academic_Project_Id", "Students", "Project", "Id")
                 .WithColumn("StudentId").AsInt32().Nullable().ForeignKey("FK_Academic_Personal_Id", "Students", "Personal", "Id")
                  .WithColumn("SkillId").AsInt32().Nullable().ForeignKey("FK_Academic_StudentsSkills_Id", "Students", "StudentsSkills", "Id");
        }
    }
}
