using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Organisation.Columns;

[ColumnsScript("Organisation.Semesters")]
[BasedOnRow(typeof(SemestersRow), CheckNames = true)]
public class SemestersColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public int Semester { get; set; }
    public int AcademicYearsId { get; set; }
    public int Index { get; set; }
}