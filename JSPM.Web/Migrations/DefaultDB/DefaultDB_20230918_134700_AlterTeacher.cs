using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{
    [Migration(20230918_134700)]
    public class DefaultDB_20230918_134700_AlterTeacher : AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("TeacherEndorsement").InSchema("Students")
                 .AlterColumn("TeacherId").AsString(100).Nullable();

        }
    }
}