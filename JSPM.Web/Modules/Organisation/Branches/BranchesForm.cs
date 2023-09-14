using Serenity.ComponentModel;

namespace JSPM.Organisation.Forms;

[FormScript("Organisation.Branches")]
[BasedOnRow(typeof(BranchesRow), CheckNames = true)]
public class BranchesForm
{
    public string BranchName { get; set; }
    public string BranchCode { get; set; }
    public int InstituteId { get; set; }
    public int DepartmentId { get; set; }
}