using FluentMigrator;
using Serenity.Data;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230915_154100)]
    public class DefaultDB_20230915_154100_AlterSubjects : AutoReversingMigration
    {
        public override void Up()
        {       

           Alter.Table("Subjects")
                 
                  .AlterColumn("Priority").AsInt16().Nullable()
                 
                    .AddColumn("SubjectCode").AsString(100).Nullable()
                   .AddColumn("Description").AsString(100).Nullable()
                   .AddColumn("SubjectType").AsString(100).Nullable();
        }
    }
}