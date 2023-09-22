using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Examinations;

[ConnectionKey("Default"), Module("Examinations"), TableName("[Examination].[ExamAttemptDetails]")]
[DisplayName("Exam Attempt Details"), InstanceName("Exam Attempt Details")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class ExamAttemptDetailsRow : Row<ExamAttemptDetailsRow.RowFields>, IIdRow
{
    const string jExamQuestion = nameof(jExamQuestion);
    const string jBranch = nameof(jBranch);

    [DisplayName("Id"), PrimaryKey, NotNull, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Exam Question"), ForeignKey("[Examination].[ExamQuestions]", "Id"), LeftJoin(jExamQuestion), TextualField(nameof(ExamQuestionQuestionNumber))]
    public long? ExamQuestionId
    {
        get => fields.ExamQuestionId[this];
        set => fields.ExamQuestionId[this] = value;
    }

    [DisplayName("Numberof Attempts")]
    public int? NumberofAttempts
    {
        get => fields.NumberofAttempts[this];
        set => fields.NumberofAttempts[this] = value;
    }

    [DisplayName("Branch"), ForeignKey("[organisation].[Branches]", "Id"), LeftJoin(jBranch), TextualField(nameof(BranchName))]
    public int? BranchId
    {
        get => fields.BranchId[this];
        set => fields.BranchId[this] = value;
    }

    [DisplayName("Exam Question Question Number"), Expression($"{jExamQuestion}.[QuestionNumber]")]
    public string ExamQuestionQuestionNumber
    {
        get => fields.ExamQuestionQuestionNumber[this];
        set => fields.ExamQuestionQuestionNumber[this] = value;
    }

    [DisplayName("Branch Branch Name"), Expression($"{jBranch}.[Branch Name]")]
    public string BranchName
    {
        get => fields.BranchName[this];
        set => fields.BranchName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int64Field ExamQuestionId;
        public Int32Field NumberofAttempts;
        public Int32Field BranchId;

        public StringField ExamQuestionQuestionNumber;
        public StringField BranchName;
    }
}