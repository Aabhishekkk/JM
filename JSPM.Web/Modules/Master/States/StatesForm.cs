using Serenity.ComponentModel;

namespace JSPM.Master.Forms;

[FormScript("Master.States")]
[BasedOnRow(typeof(StatesRow), CheckNames = true)]
public class StatesForm
{
    public string Name { get; set; }
}