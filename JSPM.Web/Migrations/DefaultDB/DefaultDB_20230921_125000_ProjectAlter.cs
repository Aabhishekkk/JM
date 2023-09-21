using FluentMigrator;
using Serenity.Extensions;
using System;


namespace JSPM.Migrations.DefaultDB
{
    [Migration(20230921_125000)]
    public class DefaultDB_20230921_125000_ProjectAlter : AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("Project").InSchema("Students")


                    .AlterColumn("ProjectTitle").AsString(300).Nullable();

        }
    }
}
