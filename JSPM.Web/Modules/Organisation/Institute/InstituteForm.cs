using Serenity.ComponentModel;

namespace JSPM.Organisation.Forms;

[FormScript("Organisation.Institute")]
[BasedOnRow(typeof(InstituteRow), CheckNames = true)]
public class InstituteForm
{
    public string InstituteName { get; set; }
    public string Description { get; set; }
}