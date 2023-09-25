using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Students.Pages;

[PageAuthorize(typeof(AcademicRow))]
public class AcademicPage : Controller
{
    [Route("Students/Academic")]
    public ActionResult Index()
    {
        return this.GridPage("@/Students/Academic/AcademicPage",
            AcademicRow.Fields.PageTitle());
    }
}