using FluentMigrator;
using Serenity.Extensions;
using System;


namespace JSPM.Migrations.DefaultDB
{
    [Migration(20231809173300)]
    public class DefaultDB_20231809_173300_AlterSemesters: AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("Semesters").InSchema("organisation")


                    .AlterColumn("Semester").AsString(20).Nullable();

        }
    }
}
