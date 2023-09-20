using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{
    [Migration(20230920_115300)]
    public class DefaultDB_20230920_115300_AlterPersonal: AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("Personal").InSchema("Students")


                    .AddColumn("DivisionId").AsInt32().Nullable().ForeignKey("FK_Personal_Division_Id", "organisation", "Division", "Id")
            .AddColumn("SemesterId").AsInt32().Nullable().ForeignKey("FK_Personal_Semesters_Id", "organisation", "Semesters", "Id");

        }
    }
}