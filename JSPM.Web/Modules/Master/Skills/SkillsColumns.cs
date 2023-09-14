using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Master.Columns;

[ColumnsScript("Master.Skills")]
[BasedOnRow(typeof(SkillsRow), CheckNames = true)]
public class SkillsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
}