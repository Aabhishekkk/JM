using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_195700)]
    public class DefaultDB_20230821_195700_AcademicSubjectLevel : AutoReversingMigration
    {
        public override void Up()
        {

            Create.Table("AcademicSubjectLevel").InSchema("Students")
                 .WithColumn("Id").AsInt32()
                 .Identity().PrimaryKey().NotNullable()
                 .WithColumn("BranchId").AsInt32().Nullable().ForeignKey("FK_AcademicSubjectLevel_Branches_Id", "organisation", "Branches", "Id")
                    .WithColumn("AcademicYearId").AsInt32().Nullable().ForeignKey("FK_AcademicSubjectLevel_AcademicYear_Id", "organisation", "AcademicYears", "Id")
                 .WithColumn("SemesterId").AsInt32().Nullable().ForeignKey("FK_AcademicSubjectLevel_Semesters_Id", "organisation", "Semesters", "Id")

                .WithColumn("DivisionId").AsInt32().Nullable().ForeignKey("FK_AcademicSubjectLevel_Division_Id",
                    "organisation", "Division", "Id")
                .WithColumn("SubjectId").AsInt32().Nullable().ForeignKey("FK_AcademicSubjectLevel_Subjects_Id", "Subjects", "Id")

                .WithColumn("Month").AsInt32().NotNullable()
                .WithColumn("Year").AsInt32().NotNullable()
                .WithColumn("eStatus").AsString().NotNullable()
                .WithColumn("Grade").AsString(50).NotNullable()
                .WithColumn("Percentage").AsDecimal().NotNullable()

                .WithColumn("StudentId").AsInt32().Nullable().ForeignKey("FK_AcademicSubjectLevel_Personal_Id", "Students", "Personal", "Id");




        }
    }
}