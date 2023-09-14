using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Organisation.Columns;

[ColumnsScript("Organisation.Group")]
[BasedOnRow(typeof(GroupRow), CheckNames = true)]
public class GroupColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string BatchName { get; set; }
    [EditLink]
    public string GroupName { get; set; }
}