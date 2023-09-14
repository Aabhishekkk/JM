using Serenity.ComponentModel;

namespace JSPM.Students.Forms;

[FormScript("Students.TeacherEndorsement")]
[BasedOnRow(typeof(TeacherEndorsementRow), CheckNames = true)]
public class TeacherEndorsementForm
{
    public int TeacherId { get; set; }
    public int StudentId { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
}