using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Students.Columns;

[ColumnsScript("Students.StudentsSkills")]
[BasedOnRow(typeof(StudentsSkillsRow), CheckNames = true)]
public class StudentsSkillsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string SkillCategory { get; set; }
    public int SkillId { get; set; }
    public int Rating { get; set; }
    public string AknowledgeBy { get; set; }
    public string Certification { get; set; }
    public string CertificationDetails { get; set; }
    public string SkillName { get; set; }
    
}