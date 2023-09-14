using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_192100)]
    public class DefaultDB_20230821_192100_Project : AutoReversingMigration
    {
        public override void Up()
        {



            Create.Table("Project").InSchema("Students")
                 .WithColumn("Id").AsInt32()
                 .Identity().PrimaryKey().NotNullable()
                  .WithColumn("StudentId").AsInt32().Nullable().ForeignKey("FK_Project_Personal_Id", "Students", "Personal", "Id")
                  .WithColumn("Type").AsString(100).NotNullable()
                    .WithColumn("ProjectTitle").AsString(100).Nullable()
                   .WithColumn("ProjectDetails").AsString(1000).Nullable()
                  .WithColumn("ProjectReport").AsString(500).Nullable();



        }
    }
}