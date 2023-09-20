using Serenity.ComponentModel;

namespace JSPM.Syllabus.Forms;

[FormScript("Syllabus.Subjects")]
[BasedOnRow(typeof(SubjectsRow), CheckNames = true)]
public class SubjectsForm
{
    public string SubjectCode { get; set; }
    public string SubjectName { get; set; }
    public int BranchId { get; set; }
    public int AcademicYearId { get; set; }
    public int SemesterId { get; set; }
    public short Priority { get; set; }

    public string Description { get; set; }

    public string SubjectType { get; set; }

   
}