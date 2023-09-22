using Serenity.ComponentModel;

namespace JSPM.Examinations.Forms;

[FormScript("Examinations.Exams")]
[BasedOnRow(typeof(ExamsRow), CheckNames = true)]
public class ExamsForm
{
    public string ExamName { get; set; }
    public string ExamInstructions { get; set; }
}