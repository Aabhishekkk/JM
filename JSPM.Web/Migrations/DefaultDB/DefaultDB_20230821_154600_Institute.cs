using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_154600)]
    public class DefaultDB_20230821_154600_Institute : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Schema("organisation");

            Create.Table("Institute").InSchema("organisation")
                .WithColumn("Id").AsInt32()
                .Identity().PrimaryKey().NotNullable()
                .WithColumn("Institute Name").AsString(200).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable();
                
        }
    }
}
