using Serenity.ComponentModel;

namespace JSPM.Syllabus.Forms;

[FormScript("Syllabus.Subjects")]
[BasedOnRow(typeof(SubjectsRow), CheckNames = true)]
public class SubjectsForm
{
    public string SubjectName { get; set; }
    public int BranchId { get; set; }
    public int AcademicYearId { get; set; }
    public int SemesterId { get; set; }
    public string Priority { get; set; }
}