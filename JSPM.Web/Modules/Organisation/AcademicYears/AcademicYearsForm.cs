using Serenity.ComponentModel;

namespace JSPM.Organisation.Forms;

[FormScript("Organisation.AcademicYears")]
[BasedOnRow(typeof(AcademicYearsRow), CheckNames = true)]
public class AcademicYearsForm
{
    public int AcademicYear { get; set; }
    public int Index { get; set; }
}