using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Examinations;

[ConnectionKey("Default"), Module("Examinations"), TableName("[Examination].[ExamQuestions]")]
[DisplayName("Exam Questions"), InstanceName("Exam Questions")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class ExamQuestionsRow : Row<ExamQuestionsRow.RowFields>, IIdRow, INameRow
{
    const string jSem = nameof(jSem);
    const string jBranch = nameof(jBranch);

    [DisplayName("Id"), PrimaryKey, NotNull, IdProperty]
    public long? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Sub Id"), NotNull]
    public long? SubId
    {
        get => fields.SubId[this];
        set => fields.SubId[this] = value;
    }

    [DisplayName("Question Number"), Size(255), QuickSearch, NameProperty]
    public string QuestionNumber
    {
        get => fields.QuestionNumber[this];
        set => fields.QuestionNumber[this] = value;
    }

    [DisplayName("Question Description")]
    public string QuestionDescription
    {
        get => fields.QuestionDescription[this];
        set => fields.QuestionDescription[this] = value;
    }

    [DisplayName("Question Type"), Size(100)]
    public string QuestionType
    {
        get => fields.QuestionType[this];
        set => fields.QuestionType[this] = value;
    }

    [DisplayName("Marks")]
    public long? Marks
    {
        get => fields.Marks[this];
        set => fields.Marks[this] = value;
    }

    [DisplayName("Sem"), ForeignKey("[organisation].[Semesters ]", "Id"), LeftJoin(jSem), TextualField(nameof(Semester))]
    public int? SemId
    {
        get => fields.SemId[this];
        set => fields.SemId[this] = value;
    }

    [DisplayName("Branch"), ForeignKey("[organisation].[Branches]", "Id"), LeftJoin(jBranch), TextualField(nameof(BranchName))]
    public int? BranchId
    {
        get => fields.BranchId[this];
        set => fields.BranchId[this] = value;
    }

    [DisplayName("Sem Semester"), Expression($"{jSem}.[Semester]")]
    public string Semester
    {
        get => fields.Semester[this];
        set => fields.Semester[this] = value;
    }

    [DisplayName("Branch Branch Name"), Expression($"{jBranch}.[Branch Name]")]
    public string BranchName
    {
        get => fields.BranchName[this];
        set => fields.BranchName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int64Field Id;
        public Int64Field SubId;
        public StringField QuestionNumber;
        public StringField QuestionDescription;
        public StringField QuestionType;
        public Int64Field Marks;
        public Int32Field SemId;
        public Int32Field BranchId;

        public StringField Semester;
        public StringField BranchName;
    }
}