using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Organisation.Pages;

[PageAuthorize(typeof(BatchesRow))]
public class BatchesPage : Controller
{
    [Route("Organisation/Batches")]
    public ActionResult Index()
    {
        return this.GridPage("@/Organisation/Batches/BatchesPage",
            BatchesRow.Fields.PageTitle());
    }
}