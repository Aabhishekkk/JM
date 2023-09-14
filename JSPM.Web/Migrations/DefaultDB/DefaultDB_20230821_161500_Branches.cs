using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_161500)]
    public class DefaultDB_20230821_161500_Branches : AutoReversingMigration
    {
        public override void Up()
        {
            

            Create.Table("Branches").InSchema("organisation")
                .WithColumn("Id").AsInt32()
                .Identity().PrimaryKey().NotNullable()
                .WithColumn("Branch Name").AsString(200).NotNullable()
                .WithColumn("Branch Code").AsString(50).NotNullable()
               
                .WithColumn("Institute_Id").AsInt32().Nullable().ForeignKey("FK_Branches_Institute_Id", "organisation", "Institute", "Id")
                .WithColumn("Department_Id").AsInt32().Nullable().ForeignKey("FK_Branches_Department_Id", "organisation", "Departments", "Id");





        }
    }
}