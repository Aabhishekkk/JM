using Serenity.ComponentModel;

namespace JSPM.Organisation.Forms;

[FormScript("Organisation.Departments")]
[BasedOnRow(typeof(DepartmentsRow), CheckNames = true)]
public class DepartmentsForm
{
    public string DepartmentName { get; set; }
}