using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Jobs.Columns;

[ColumnsScript("Jobs.JobsOpenings")]
[BasedOnRow(typeof(JobsOpeningsRow), CheckNames = true)]
public class JobsOpeningsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string TypeOfEmployement { get; set; }
    public string Description { get; set; }
    public string Levels { get; set; }
    public int Vacancy { get; set; }
    public string CompanyName { get; set; }
    public string Location { get; set; }
    public string Role { get; set; }
    public string Budget { get; set; }
    public string Shift { get; set; }
    public string Skills { get; set; }
    public string SkillsSkillCategory { get; set; }
}