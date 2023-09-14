using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Organisation.Pages;

[PageAuthorize(typeof(SemestersRow))]
public class SemestersPage : Controller
{
    [Route("Organisation/Semesters")]
    public ActionResult Index()
    {
        return this.GridPage("@/Organisation/Semesters/SemestersPage",
            SemestersRow.Fields.PageTitle());
    }
}