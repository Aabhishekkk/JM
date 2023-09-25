using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{
    [Migration(20230925_142600)]
    public class DefaultDB_20230925_142600_AlterStudentsSkills : AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("StudentsSkills").InSchema("Students")


                    .AddColumn("Skills").AsString(100).Nullable();


        }
    }
}
