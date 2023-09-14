using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Organisation.Columns;

[ColumnsScript("Organisation.Institute")]
[BasedOnRow(typeof(InstituteRow), CheckNames = true)]
public class InstituteColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string InstituteName { get; set; }
    public string Description { get; set; }
}