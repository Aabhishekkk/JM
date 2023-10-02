using Serenity.ComponentModel;

namespace JSPM.Students.Forms;

[FormScript("Students.Academics")]
[BasedOnRow(typeof(AcademicsRow), CheckNames = true)]
public class AcademicsForm
{
    public string CourseLevel { get; set; }
    public string CourseName { get; set; }
    public string YearOfPassing { get; set; }
    public string Percentage { get; set; }
    public string Remark { get; set; }
    public string PassingType { get; set; }
    public int ProjectId { get; set; }
    public int StudentId { get; set; }
    public int SkillId { get; set; }
}