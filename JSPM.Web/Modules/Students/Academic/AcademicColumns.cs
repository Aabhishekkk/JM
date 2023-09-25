using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Students.Columns;

[ColumnsScript("Students.Academic")]
[BasedOnRow(typeof(AcademicRow), CheckNames = true)]
public class AcademicColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string CourseLevel { get; set; }
    public string CourseName { get; set; }
    public string YearOfPassing { get; set; }
    public string Percentage { get; set; }
    public string Remark { get; set; }
    public string PassingType { get; set; }
    public string ProjectType { get; set; }
    public string StudentFirstName { get; set; }
    public string SkillCategory { get; set; }
}