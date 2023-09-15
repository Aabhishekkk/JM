using FluentMigrator;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230821_183800)]
    public class DefaultDB_20230821_183800_Topics : AutoReversingMigration
    {
        public override void Up()
        {


            
            Create.Table("Topics")
                 .WithColumn("Id").AsInt32()
                 .Identity().PrimaryKey().NotNullable()
                 .WithColumn("SubjectId").AsInt32().Nullable().ForeignKey("FK_Topics_Subjects_Id","Syllabus","Subjects","Id")   
                 .WithColumn("ChapterId").AsInt32().Nullable().ForeignKey("FK_Topics_Chapters_Id", "Syllabus", "Chapters", "Id")
                
                .WithColumn("TopicName").AsString(100).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("Index").AsInt32().NotNullable();


        }
    }
}