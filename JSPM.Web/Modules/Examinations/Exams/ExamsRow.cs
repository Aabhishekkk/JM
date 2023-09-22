using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace JSPM.Examinations;

[ConnectionKey("Default"), Module("Examinations"), TableName("[Examination].[Exams]")]
[DisplayName("Exams"), InstanceName("Exams")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class ExamsRow : Row<ExamsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), PrimaryKey, NotNull, IdProperty]
    public Guid? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Exam Name"), Size(500), NotNull, QuickSearch, NameProperty]
    public string ExamName
    {
        get => fields.ExamName[this];
        set => fields.ExamName[this] = value;
    }

    [DisplayName("Exam Instructions"), Size(1000)]
    public string ExamInstructions
    {
        get => fields.ExamInstructions[this];
        set => fields.ExamInstructions[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public GuidField Id;
        public StringField ExamName;
        public StringField ExamInstructions;

    }
}