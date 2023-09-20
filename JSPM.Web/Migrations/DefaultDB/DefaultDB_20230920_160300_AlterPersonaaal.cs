using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{
    [Migration(20230920_160300)]
    public class DefaultDB_20230920_160300_AlterPersonaaal : AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("Personal").InSchema("Students")


                    .AddColumn("CurrentState").AsString(100).Nullable();
            

        }
    }
}
