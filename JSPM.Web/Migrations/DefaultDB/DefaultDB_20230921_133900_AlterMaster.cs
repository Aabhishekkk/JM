using FluentMigrator;
using Serenity.Extensions;
using System;


namespace JSPM.Migrations.DefaultDB
{
    [Migration(20230921_133900)]
    public class DefaultDB_20230921_133900_AlterMaster : AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("Skills").InSchema("Master")


                    .AddColumn("SkillCategory").AsString(300).Nullable();

        }
    }
}