using FluentMigrator;
using Serenity.Data;
using Serenity.Extensions;
using System;

namespace JSPM.Migrations.DefaultDB
{ 
    [Migration(20230920_161700)]
    public class DefaultDB_20230920_161700_AlterChapters : AutoReversingMigration
    {
        public override void Up()
        {

            Alter.Table("Chapters")

                   .AlterColumn("Description").AsString(2000).Nullable();
                 
                  
        }
    }
}