using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230822_151400)]
    public class DefaultDB_20230822_151400_States : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Schema("Master");

            Create.Table("States").InSchema("Master")
                 .WithColumn("Id").AsInt32()
                 .Identity().PrimaryKey().NotNullable()
                 .WithColumn("Name").AsString(100).NotNullable();
             

        }
    }
}