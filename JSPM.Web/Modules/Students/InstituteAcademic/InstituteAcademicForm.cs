using Serenity.ComponentModel;

namespace JSPM.Students.Forms;

[FormScript("Students.InstituteAcademic")]
[BasedOnRow(typeof(InstituteAcademicRow), CheckNames = true)]
public class InstituteAcademicForm
{
    public int BranchId { get; set; }
    public int AcademicYearId { get; set; }
    public int SemesterId { get; set; }
    public int DivisionId { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public string EStatus { get; set; }
    public string Grade { get; set; }
    public decimal Percentage { get; set; }
    public int StudentId { get; set; }
}