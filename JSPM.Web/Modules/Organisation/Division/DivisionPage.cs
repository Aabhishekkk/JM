using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Organisation.Pages;

[PageAuthorize(typeof(DivisionRow))]
public class DivisionPage : Controller
{
    [Route("Organisation/Division")]
    public ActionResult Index()
    {
        return this.GridPage("@/Organisation/Division/DivisionPage",
            DivisionRow.Fields.PageTitle());
    }
}