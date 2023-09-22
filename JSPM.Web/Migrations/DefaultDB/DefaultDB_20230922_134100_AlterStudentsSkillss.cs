using FluentMigrator;
using Serenity.Extensions;
using System;


namespace JSPM.Migrations.DefaultDB
{
    [Migration(20230922_134100)]
    public class DefaultDB_20230922_134100_AlterStudentsSkillss : AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("StudentsSkills").InSchema("Students")


                    .AddColumn("SkillName").AsString(300).Nullable();

        }
    }
}