using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Organisation.Columns;

[ColumnsScript("Organisation.Departments")]
[BasedOnRow(typeof(DepartmentsRow), CheckNames = true)]
public class DepartmentsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string DepartmentName { get; set; }
}