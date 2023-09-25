using FluentMigrator;
using System;

namespace JSPM.Migrations.DefaultDB
{
    [Migration(20230925_135200)]
    public class DefaultDB_20230925_135200_JobsOpenings : AutoReversingMigration
    {
        public override void Up()
        {

            Create.Schema("Job");

            Create.Table("JobsOpenings").InSchema("Job")
                .WithColumn("Id").AsInt32()
                .Identity().PrimaryKey().NotNullable()
                .WithColumn("Type of Employement").AsString(200).NotNullable()
                .WithColumn("Description").AsString(1000).NotNullable()
                .WithColumn("Levels").AsString(100).Nullable()
                .WithColumn("Vacancy").AsInt32().Nullable()
                .WithColumn("CompanyName").AsString(500).NotNullable()
                .WithColumn("Location").AsString(1000).NotNullable()
                .WithColumn("Role").AsString(100).Nullable()
                .WithColumn("Budget").AsString(500).NotNullable()
                .WithColumn("Shift").AsString(100).NotNullable()
                .WithColumn("Skills").AsString(1000).NotNullable()
                .WithColumn("SkillsId").AsInt32().Nullable().ForeignKey("FK_JobsOpenings_Skills_Id", "Students", "StudentsSkills", "Id");




        }
    }
}