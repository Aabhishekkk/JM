using Serenity.ComponentModel;

namespace JSPM.Organisation.Forms;

[FormScript("Organisation.Group")]
[BasedOnRow(typeof(GroupRow), CheckNames = true)]
public class GroupForm
{
    public int BatchId { get; set; }
    public string GroupName { get; set; }
}