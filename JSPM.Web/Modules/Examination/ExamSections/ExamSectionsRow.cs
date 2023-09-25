using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace JSPM.Examination;

[ConnectionKey("Default"), Module("Examination"), TableName("[Examination].[ExamSections]")]
[DisplayName("Exam Sections"), InstanceName("Exam Sections")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class ExamSectionsRow : Row<ExamSectionsRow.RowFields>, IIdRow, INameRow
{
    const string jExam = nameof(jExam);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Name"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }

    [DisplayName("Display Name"), Size(1000)]
    public string DisplayName
    {
        get => fields.DisplayName[this];
        set => fields.DisplayName[this] = value;
    }

    [DisplayName("Exam"), ForeignKey("[Examination].[Exams]", "Id"), LeftJoin(jExam), TextualField(nameof(ExamName))]
    public Guid? ExamId
    {
        get => fields.ExamId[this];
        set => fields.ExamId[this] = value;
    }

    [DisplayName("Instructions")]
    public string Instructions
    {
        get => fields.Instructions[this];
        set => fields.Instructions[this] = value;
    }

    [DisplayName("Section Duration In Seconds")]
    public int? SectionDurationInSeconds
    {
        get => fields.SectionDurationInSeconds[this];
        set => fields.SectionDurationInSeconds[this] = value;
    }

    [DisplayName("Number Of Questions")]
    public int? NumberOfQuestions
    {
        get => fields.NumberOfQuestions[this];
        set => fields.NumberOfQuestions[this] = value;
    }

    [DisplayName("Numberof Mandatory Questions")]
    public int? NumberofMandatoryQuestions
    {
        get => fields.NumberofMandatoryQuestions[this];
        set => fields.NumberofMandatoryQuestions[this] = value;
    }

    [DisplayName("Exam Exam Name"), Expression($"{jExam}.[ExamName]")]
    public string ExamName
    {
        get => fields.ExamName[this];
        set => fields.ExamName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField DisplayName;
        public GuidField ExamId;
        public StringField Instructions;
        public Int32Field SectionDurationInSeconds;
        public Int32Field NumberOfQuestions;
        public Int32Field NumberofMandatoryQuestions;

        public StringField ExamName;
    }
}