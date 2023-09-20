using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{
    [Migration(20230915_161500)]
    public class DefaultDB_20230915_161500_AlterProject: AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("Project").InSchema("Students")


                    .AddColumn("DepartmentId").AsInt32().Nullable().ForeignKey("FK_Project_Departments_Id", "organisation", "Departments", "Id")
            .AddColumn("SemesterId").AsInt32().Nullable().ForeignKey("FK_Project_Semesters_Id", "organisation", "Semesters", "Id");

        }
    }
}