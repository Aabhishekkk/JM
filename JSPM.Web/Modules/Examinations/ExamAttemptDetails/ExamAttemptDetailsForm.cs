using Serenity.ComponentModel;

namespace JSPM.Examinations.Forms;

[FormScript("Examinations.ExamAttemptDetails")]
[BasedOnRow(typeof(ExamAttemptDetailsRow), CheckNames = true)]
public class ExamAttemptDetailsForm
{
    public long ExamQuestionId { get; set; }
    public int NumberofAttempts { get; set; }
    public int BranchId { get; set; }
}