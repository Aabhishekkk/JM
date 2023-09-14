using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Students.Columns;

[ColumnsScript("Students.Skills")]
[BasedOnRow(typeof(SkillsRow), CheckNames = true)]
public class SkillsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string SkillCategory { get; set; }
    public int Rating { get; set; }
    public string AknowledgeBy { get; set; }
    public string Certification { get; set; }
    public string CertificationDetails { get; set; }
    public string StudentFirstName { get; set; }
}