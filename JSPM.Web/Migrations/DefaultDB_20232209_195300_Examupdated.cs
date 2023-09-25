
using FluentMigrator;
using Serenity.Extensions;
using System;


namespace JSPM.Migrations.DefaultDB
{
    [Migration(20232209_195300)]
    public class DefaultDB_20232209_195300_Examupdated : AutoReversingMigration
    {
        public override void Up()
        {

            Create.Schema("Examination");

            Create.Table("Exams").InSchema("Examination")
             .WithColumn("Id").AsGuid().NotNullable().PrimaryKey()
             .WithColumn("ExamName").AsString(500).NotNullable()
             .WithColumn("ExamInstructions").AsString(1000).Nullable();

            Create.Table("ExamSections").InSchema("Examination")
             .WithColumn("Id").AsInt32()
             .Identity().PrimaryKey().NotNullable()
             .WithColumn("Name").AsString(500).NotNullable()
             .WithColumn("DisplayName").AsString(1000).Nullable()
             .WithColumn("ExamId").AsGuid().Nullable().ForeignKey("ExamSections_Exams_Id", "Examination", "Exams", "Id")
             .WithColumn("Instructions").AsString(int.MaxValue).Nullable()
             .WithColumn("SectionDurationInSeconds").AsInt32().Nullable()
             .WithColumn("NumberOfQuestions").AsInt32().Nullable()
             .WithColumn("NumberofMandatoryQuestions").AsInt32().Nullable();


            Create.Table("ExamQuestions").InSchema("Examination")
             .WithColumn("Id").AsInt64().NotNullable().PrimaryKey()
             .WithColumn("SubId").AsInt64().Nullable()
             .WithColumn("QuestionNumber").AsString().Nullable()
             .WithColumn("QuestionDescription").AsString(10000).Nullable()
             .WithColumn("QuestionType").AsString(100).Nullable()
             .WithColumn("Marks").AsInt64().Nullable()
             .WithColumn("SemId").AsInt32().Nullable().ForeignKey("FK_ExamQuestions_Semesters_Id", "organisation", "Semesters", "Id")
             .WithColumn("BranchId").AsInt32().Nullable().ForeignKey("FK_ExamQuestions_Branches_Id", "organisation", "Branches", "Id");



            Create.Table("ExamAttemptDetails").InSchema("Examination")
            .WithColumn("Id").AsInt32().NotNullable().PrimaryKey()
            .WithColumn("ExamQuestionId").AsInt64().Nullable().ForeignKey("ExamAttemptDetails_ExamQuestions_Id", "Examination", "ExamQuestions", "Id")
            .WithColumn("NumberofAttempts").AsInt32().Nullable()
            .WithColumn("BranchId").AsInt32().Nullable().ForeignKey("ExamAttempt_Branches_Id", "organisation", "Branches", "Id");

        }
    }
}
