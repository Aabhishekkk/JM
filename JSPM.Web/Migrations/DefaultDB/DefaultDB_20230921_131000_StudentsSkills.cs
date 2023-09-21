
using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{
    [Migration(20230921_131000)]
    public class DefaultDB_20230921_131000_StudentsSkills : AutoReversingMigration
    {
        public override void Up()
        {



            Create.Table("StudentsSkills").InSchema("Students")
                .WithColumn("Id").AsInt32()
                .Identity().PrimaryKey().NotNullable()
                .WithColumn("SkillCategory").AsString(100).Nullable()
                 .WithColumn("SkillId").AsInt32().Nullable().ForeignKey("StudentsSkills_Master_Id", "Master", "Skills", "Id")
                 .WithColumn("Rating").AsInt32().Nullable()
                  .WithColumn("AknowledgeBy").AsString(100).Nullable()
                   .WithColumn("Certification").AsString(150).Nullable()
                  .WithColumn("Certification details").AsString(100).Nullable()
                 .WithColumn("StudentId").AsInt32().Nullable().ForeignKey("StudentsSkills_Personal_Id", "Students", "Personal", "Id");






        }
    }
}