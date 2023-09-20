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

    public string SubjectCode { get; set; }
    public string SubjectName { get; set; }
    public string BranchName { get; set; }
    public int AcademicYearId { get; set; }
    public int SemesterId { get; set; }
    public short Priority { get; set; }

    public string Description { get; set; }

    public string SubjectType { get; set; }

}