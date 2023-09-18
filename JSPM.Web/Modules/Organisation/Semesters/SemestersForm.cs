using Serenity.ComponentModel;
using System;

namespace JSPM.Organisation.Forms;

[FormScript("Organisation.Semesters")]
[BasedOnRow(typeof(SemestersRow), CheckNames = true)]
public class SemestersForm
{
    public String Semester { get; set; }
    public int AcademicYearsId { get; set; }
    public int Index { get; set; }
}