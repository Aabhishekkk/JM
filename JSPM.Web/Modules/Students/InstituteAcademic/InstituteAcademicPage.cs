using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Students.Pages;

[PageAuthorize(typeof(InstituteAcademicRow))]
public class InstituteAcademicPage : Controller
{
    [Route("Students/InstituteAcademic")]
    public ActionResult Index()
    {
        return this.GridPage("@/Students/InstituteAcademic/InstituteAcademicPage",
            InstituteAcademicRow.Fields.PageTitle());
    }
}