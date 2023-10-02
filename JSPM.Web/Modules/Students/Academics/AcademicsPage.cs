using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Students.Pages;

[PageAuthorize(typeof(AcademicsRow))]
public class AcademicsPage : Controller
{
    [Route("Students/Academics")]
    public ActionResult Index()
    {
        return this.GridPage("@/Students/Academics/AcademicsPage",
            AcademicsRow.Fields.PageTitle());
    }
}