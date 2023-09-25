using Serenity.ComponentModel;

namespace JSPM.Examination.Forms;

[FormScript("Examination.Exams")]
[BasedOnRow(typeof(ExamsRow), CheckNames = true)]
public class ExamsForm
{
    public string ExamName { get; set; }
    public string ExamInstructions { get; set; }
}