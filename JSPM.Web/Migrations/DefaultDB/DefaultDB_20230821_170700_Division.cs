using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_170700)]
    public class DefaultDB_20230821_170700_Division : AutoReversingMigration
    {
        public override void Up()
        {


            Create.Table("Division").InSchema("organisation")
                .WithColumn("Id").AsInt32()
                .Identity().PrimaryKey().NotNullable()
                .WithColumn("InstituteId").AsInt32().Nullable().ForeignKey("FK_Institute_Id", "organisation", "Institute", "Id")
                .WithColumn("Branch Id").AsInt32().Nullable().ForeignKey("FK_Branches__Id", "organisation", "Branches", "Id")
                .WithColumn("Department Id").AsInt32().Nullable().ForeignKey("FK_Departments_Id", "organisation", "Departments", "Id")
                .WithColumn("AcademicYears Id").AsInt32().Nullable().ForeignKey("FK_AcademicYear_Id", "organisation", "AcademicYears", "Id")
                .WithColumn("Semester Id").AsInt32().Nullable().ForeignKey("FK_Semesters_Id", "organisation", "Semesters", "Id")
                .WithColumn("Start Date").AsDate().NotNullable()
                .WithColumn("End Date").AsDate().Nullable()
                .WithColumn("Division Name").AsString(100).NotNullable();
                                          

        }
    }
}