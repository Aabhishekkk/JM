using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Organisation.Columns;

[ColumnsScript("Organisation.Branches")]
[BasedOnRow(typeof(BranchesRow), CheckNames = true)]
public class BranchesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string BranchName { get; set; }
    public string BranchCode { get; set; }
    public string InstituteName { get; set; }
    public string DepartmentName { get; set; }
}