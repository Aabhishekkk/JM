using Serenity.ComponentModel;
using System;

namespace JSPM.Organisation.Forms;

[FormScript("Organisation.AcademicYears")]
[BasedOnRow(typeof(AcademicYearsRow), CheckNames = true)]
public class AcademicYearsForm
{
    public String AcademicYear { get; set; }
    public int Index { get; set; }
}