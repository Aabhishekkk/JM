using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Organisation.Pages;

[PageAuthorize(typeof(InstituteRow))]
public class InstitutePage : Controller
{
    [Route("Organisation/Institute")]
    public ActionResult Index()
    {
        return this.GridPage("@/Organisation/Institute/InstitutePage",
            InstituteRow.Fields.PageTitle());
    }
}