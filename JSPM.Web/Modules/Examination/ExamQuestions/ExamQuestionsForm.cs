using Serenity.ComponentModel;

namespace JSPM.Examination.Forms;

[FormScript("Examination.ExamQuestions")]
[BasedOnRow(typeof(ExamQuestionsRow), CheckNames = true)]
public class ExamQuestionsForm
{
    public long SubId { get; set; }
    public string QuestionNumber { get; set; }
    public string QuestionDescription { get; set; }
    public string QuestionType { get; set; }
    public long Marks { get; set; }
    public int SemId { get; set; }
    public int BranchId { get; set; }
}