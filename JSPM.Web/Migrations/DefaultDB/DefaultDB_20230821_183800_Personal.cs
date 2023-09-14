using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_190400)]
    public class DefaultDB_20230821_190400_Personal : AutoReversingMigration
    {
        public override void Up()
        {



            Create.Schema("Students");

            Create.Table("Personal").InSchema("Students")
                  .WithColumn("Id").AsInt32()
                  .Identity().PrimaryKey().NotNullable()
                  .WithColumn("FirstName").AsString(100).NotNullable()
                  .WithColumn("LastName").AsString(100).NotNullable()
                  .WithColumn("MiddleName").AsString(100).Nullable()
                  .WithColumn("Email").AsString(250).NotNullable()
                  .WithColumn("Mobile number").AsInt32().NotNullable()
                  .WithColumn("PNR").AsString(50).Nullable()
                  .WithColumn("Permanent address").AsString(300).NotNullable()
                  .WithColumn("City").AsString(50).NotNullable()

                 //.WithColumn("State_Id").AsInt32().Nullable().ForeignKey("FK_Personal_State_Id", "Student", "States", "Id")
                 .WithColumn("PIN").AsInt32().NotNullable()
                  .WithColumn("Current address").AsString(200).NotNullable()
                   .WithColumn("Current_City").AsString(50).NotNullable()
                 //.WithColumn("Current_State_Id").AsInt32().Nullable().ForeignKey("FK_Branches_Institute_Id", "Master", "States", "Id")
                 .WithColumn("Gender").AsString(50).NotNullable()
                  .WithColumn("DOB").AsDate().NotNullable()
                  .WithColumn("AdmissionDate").AsDate().NotNullable()
                 .WithColumn("Department_Id").AsInt32().Nullable().ForeignKey("FK_Personal_Department_Id", "organisation", "Departments", "Id")
                .WithColumn("Branch_Id").AsInt32().Nullable().ForeignKey("FK_Personal_Branches_Id", "organisation", "Branches", "Id");



        }
    }
}