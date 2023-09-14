using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_182200)]
    public class DefaultDB_20230821_182200_Subjects : AutoReversingMigration
    {
        public override void Up()
        {


           

            Create.Table("Subjects").InSchema("Syllabus")
                 .WithColumn("Id").AsInt32()
                 .Identity().PrimaryKey().NotNullable()
                 .WithColumn("Subject Name").AsString(200).NotNullable()
                 .WithColumn("Branch_Id").AsInt32().Nullable().ForeignKey("FK_Subjects_Branches_Id", "organisation", "Branches", "Id")
                 .WithColumn("AcademicYearId").AsInt32().Nullable().ForeignKey("FK_Subjects_AcademicYears_Id", "organisation", "AcademicYears", "Id")
                 .WithColumn("SemesterId").AsInt32().Nullable().ForeignKey("FK_Subjects_Semesters_Id", "organisation", "Semesters", "Id")
                  .WithColumn("Priority").AsString(50).Nullable();

        }
    }
}