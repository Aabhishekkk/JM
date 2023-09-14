using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_160800)]
    public class DefaultDB_20230821_160800_Departments : AutoReversingMigration
    {
        public override void Up()
        {
            

            Create.Table("Departments").InSchema("organisation")
                .WithColumn("Id").AsInt32()
                .Identity().PrimaryKey().NotNullable()
                .WithColumn("Department Name").AsString(200).NotNullable();
                
                
        }
    }
}
