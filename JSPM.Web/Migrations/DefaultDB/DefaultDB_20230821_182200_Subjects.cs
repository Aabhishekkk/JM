using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_183100)]
    public class DefaultDB_20230821_183100_Chapters: AutoReversingMigration
    {
        public override void Up()
        {


            Create.Table("Chapters").InSchema("Syllabus")
                 .WithColumn("Id").AsInt32()
                 .Identity().PrimaryKey().NotNullable()
                  .WithColumn("SubjectId").AsInt32().Nullable().ForeignKey("FK_Chapters_Subjects_Id", "Syllabus", "Subjects", "Id")
                 .WithColumn("ChapterName").AsString(200).NotNullable()
                 .WithColumn("Description").AsString(1000).Nullable()
                 .WithColumn("Index").AsInt32().Nullable();


        }
    }
}