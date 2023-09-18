using FluentMigrator;

namespace JSPM.Migrations.DefaultDB
{
    [Migration(20230821_165500)]
    public class DefaultDB_20230821_165500_Semesters : AutoReversingMigration
    {
        public override void Up()
        {


            Create.Table("Semesters ").InSchema("organisation")
                .WithColumn("Id").AsInt32()
                .Identity().PrimaryKey().NotNullable()
                .WithColumn("Semester").AsInt32().NotNullable()
                .WithColumn("AcademicYears_Id").AsInt32().Nullable().ForeignKey("FK_Semesters_AcademicYears_Id", "organisation", "AcademicYears", "Id")
                .WithColumn("Index").AsInt32().Nullable();



        }
    }
}