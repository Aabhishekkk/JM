using Serenity.ComponentModel;

namespace JSPM.Students.Forms;

[FormScript("Students.StudentsSkills")]
[BasedOnRow(typeof(StudentsSkillsRow), CheckNames = true)]
public class StudentsSkillsForm
{
    public string ESkillCategory { get; set; }
    public int SkillId { get; set; }
    public int Rating { get; set; }
    public string AknowledgeBy { get; set; }
    public string Certification { get; set; }
    public string CertificationDetails { get; set; }
    public int StudentId { get; set; }
    public short SkillCategory { get; set; }
}