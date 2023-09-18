using FluentMigrator;
using Serenity.Extensions;
using System;


namespace JSPM.Migrations.DefaultDB
{
    [Migration(20231809_134400)]
    public class DefaultDB_20231809_134400_AlterAcademicYears : AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("AcademicYears").InSchema("organisation")


                    .AlterColumn("Academic Year").AsString(20).Nullable();

        }
    }
}




