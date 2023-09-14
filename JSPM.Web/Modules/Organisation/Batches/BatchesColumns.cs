using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Organisation.Columns;

[ColumnsScript("Organisation.Batches")]
[BasedOnRow(typeof(BatchesRow), CheckNames = true)]
public class BatchesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string DivisionName { get; set; }
    [EditLink]
    public string BatchName { get; set; }
}