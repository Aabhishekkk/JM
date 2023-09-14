using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_175600)]
    public class DefaultDB_20230821_175600_Batches : AutoReversingMigration
    {
        public override void Up()
        {


            Create.Table("Batches").InSchema("organisation")
                .WithColumn("Id").AsInt32()
                .Identity().PrimaryKey().NotNullable()
                .WithColumn("DivisionId").AsInt32().Nullable().ForeignKey("FK_Batches_Division_Id", "organisation","Division", "Id")
                .WithColumn("Batch Name").AsString(100).NotNullable();
                

        }
    }
}