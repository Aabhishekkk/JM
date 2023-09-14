using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Master.Pages;

[PageAuthorize(typeof(StatesRow))]
public class StatesPage : Controller
{
    [Route("Master/States")]
    public ActionResult Index()
    {
        return this.GridPage("@/Master/States/StatesPage",
            StatesRow.Fields.PageTitle());
    }
}