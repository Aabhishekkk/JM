using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Examinations.Columns;

[ColumnsScript("Examinations.ExamQuestions")]
[BasedOnRow(typeof(ExamQuestionsRow), CheckNames = true)]
public class ExamQuestionsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public long Id { get; set; }
    public long SubId { get; set; }
    [EditLink]
    public string QuestionNumber { get; set; }
    public string QuestionDescription { get; set; }
    public string QuestionType { get; set; }
    public long Marks { get; set; }
    public string Semester { get; set; }
    public string BranchName { get; set; }
}