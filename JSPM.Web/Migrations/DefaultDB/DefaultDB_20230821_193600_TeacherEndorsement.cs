using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_193600)]
    public class DefaultDB_20230821_193600_TeacherEndorsement : AutoReversingMigration
    {
        public override void Up()
        {

            Create.Table("TeacherEndorsement").InSchema("Students")
                 .WithColumn("Id").AsInt32()
                 .Identity().PrimaryKey().NotNullable()
                  .WithColumn("TeacherId").AsInt32().Nullable()
                  .WithColumn("StudentId").AsInt32().Nullable().ForeignKey("FK_TeacherEndorsement_Personal_Id", "Students", "Personal", "Id")
                 .WithColumn("Title").AsString(100).NotNullable()
                  .WithColumn("Details").AsString(500).NotNullable();




        }
    }
}