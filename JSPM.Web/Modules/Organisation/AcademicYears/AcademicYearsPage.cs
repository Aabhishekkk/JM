using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Organisation.Pages;

[PageAuthorize(typeof(AcademicYearsRow))]
public class AcademicYearsPage : Controller
{
    [Route("Organisation/AcademicYears")]
    public ActionResult Index()
    {
        return this.GridPage("@/Organisation/AcademicYears/AcademicYearsPage",
            AcademicYearsRow.Fields.PageTitle());
    }
}