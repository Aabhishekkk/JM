using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Students.Columns;

[ColumnsScript("Students.Project")]
[BasedOnRow(typeof(ProjectRow), CheckNames = true)]
public class ProjectColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string StudentFirstName { get; set; }
    [EditLink]
    public string Type { get; set; }
    public string ProjectTitle { get; set; }
    public string ProjectDetails { get; set; }
    public string ProjectReport { get; set; }
}