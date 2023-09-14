using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_180200)]
    public class DefaultDB_20230821_180200_Group : AutoReversingMigration
    {
        public override void Up()
        {


            Create.Table("Group").InSchema("organisation")
                .WithColumn("Id").AsInt32()
                .Identity().PrimaryKey().NotNullable()
                .WithColumn("Batch Id").AsInt32().Nullable().ForeignKey("FK_Group_Batches_Id", "organisation","Batches", "Id")
                .WithColumn("Group Name").AsString(100).NotNullable();
                

        }
    }
}