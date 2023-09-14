using Serenity.ComponentModel;
using System;

namespace JSPM.Organisation.Forms;

[FormScript("Organisation.Division")]
[BasedOnRow(typeof(DivisionRow), CheckNames = true)]
public class DivisionForm
{
    public int InstituteId { get; set; }
    public int BranchId { get; set; }
    public int DepartmentId { get; set; }
    public int AcademicYearsId { get; set; }
    public int SemesterId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string DivisionName { get; set; }
}