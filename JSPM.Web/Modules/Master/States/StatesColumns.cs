using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Master.Columns;

[ColumnsScript("Master.States")]
[BasedOnRow(typeof(StatesRow), CheckNames = true)]
public class StatesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
}