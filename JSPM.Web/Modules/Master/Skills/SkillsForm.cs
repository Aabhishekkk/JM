using Serenity.ComponentModel;

namespace JSPM.Master.Forms;

[FormScript("Master.Skills")]
[BasedOnRow(typeof(SkillsRow), CheckNames = true)]
public class SkillsForm
{
    public string Name { get; set; }


    public string SkillCategory { get; set; }
}