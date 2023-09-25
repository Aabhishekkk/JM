using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_193100)]
    public class DefaultDB_20230821_193100_Skills : AutoReversingMigration
    {
        public override void Up()
        {



            Create.Table("Skills").InSchema("Students")
                .WithColumn("Id").AsInt32()
                .Identity().PrimaryKey().NotNullable()
                .WithColumn("SkillCategory").AsString(100).Nullable()
                 .WithColumn("Rating").AsInt32().NotNullable()
                  .WithColumn("AknowledgeBy").AsString(100).Nullable()
                   .WithColumn("Certification").AsString(150).Nullable()
                  .WithColumn("Certification details").AsString(100).Nullable()
                 .WithColumn("StudentId").AsInt32().Nullable().ForeignKey("FK_Skills_Personal_Id", "Students", "Personal", "Id");






        }
    }
}