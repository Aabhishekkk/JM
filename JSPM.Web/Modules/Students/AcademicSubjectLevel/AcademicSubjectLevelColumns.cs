using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Students.Columns;

[ColumnsScript("Students.AcademicSubjectLevel")]
[BasedOnRow(typeof(AcademicSubjectLevelRow), CheckNames = true)]
public class AcademicSubjectLevelColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string BranchName { get; set; }
    public int AcademicYearId { get; set; }
    public int SemesterId { get; set; }
    public string DivisionName { get; set; }
    public string SubjectName { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    [EditLink]
    public string EStatus { get; set; }
    public string Grade { get; set; }
    public decimal Percentage { get; set; }
    public string StudentFirstName { get; set; }
}