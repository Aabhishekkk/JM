using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_164700)]
    public class DefaultDB_20230821_164700_AcademicYears : AutoReversingMigration
    {
        public override void Up()
        {


            Create.Table("AcademicYears ").InSchema("organisation")
                .WithColumn("Id").AsInt32()
                .Identity().PrimaryKey().NotNullable()
                .WithColumn("Academic Year").AsInt32().NotNullable()
                .WithColumn("Index").AsInt32().Nullable();
                


        }
    }
}