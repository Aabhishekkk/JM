using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230822_152500)]
    public class DefaultDB_20230822_152500_Skills : AutoReversingMigration
    {
        public override void Up()
        {
            

            Create.Table("Skills").InSchema("Master")
                 .WithColumn("Id").AsInt32()
                 .Identity().PrimaryKey().NotNullable()
                 .WithColumn("Name").AsString(100).NotNullable();
             

        }
    }
}