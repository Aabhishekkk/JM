using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{
    [Migration(20230920_152300)]
    public class DefaultDB_20230920_152300_AlterPersonalll: AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("Personal").InSchema("Students")


                   .AlterColumn("Mobile number").AsString(12).Nullable();

        }
    }
}