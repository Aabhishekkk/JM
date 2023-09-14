using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Organisation.Pages;

[PageAuthorize(typeof(BranchesRow))]
public class BranchesPage : Controller
{
    [Route("Organisation/Branches")]
    public ActionResult Index()
    {
        return this.GridPage("@/Organisation/Branches/BranchesPage",
            BranchesRow.Fields.PageTitle());
    }
}