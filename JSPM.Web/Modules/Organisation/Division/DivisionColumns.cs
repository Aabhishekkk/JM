using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace JSPM.Organisation.Columns;

[ColumnsScript("Organisation.Division")]
[BasedOnRow(typeof(DivisionRow), CheckNames = true)]
public class DivisionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string InstituteName { get; set; }
    public string BranchName { get; set; }
    public string DepartmentName { get; set; }
    public int AcademicYearsId { get; set; }
    public int SemesterId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    [EditLink]
    public string DivisionName { get; set; }
}