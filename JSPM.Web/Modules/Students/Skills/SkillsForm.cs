using Serenity.ComponentModel;

namespace JSPM.Students.Forms;

[FormScript("Students.Skills")]
[BasedOnRow(typeof(SkillsRow), CheckNames = true)]
public class SkillsForm
{
    public string SkillCategory { get; set; }
    public int Rating { get; set; }
    public string AknowledgeBy { get; set; }
    public string Certification { get; set; }
    public string CertificationDetails { get; set; }
    public int StudentId { get; set; }
}