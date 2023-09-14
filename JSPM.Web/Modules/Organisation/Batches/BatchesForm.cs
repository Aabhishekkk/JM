using Serenity.ComponentModel;

namespace JSPM.Organisation.Forms;

[FormScript("Organisation.Batches")]
[BasedOnRow(typeof(BatchesRow), CheckNames = true)]
public class BatchesForm
{
    public int DivisionId { get; set; }
    public string BatchName { get; set; }
}