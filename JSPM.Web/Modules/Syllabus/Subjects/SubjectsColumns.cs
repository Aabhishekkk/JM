using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Syllabus.Columns;

[ColumnsScript("Syllabus.Subjects")]
[BasedOnRow(typeof(SubjectsRow), CheckNames = true)]
public class SubjectsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string SubjectName { get; set; }
    public string BranchName { get; set; }
    public int AcademicYearId { get; set; }
    public int SemesterId { get; set; }
    public string Priority { get; set; }
}