using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Students.Pages;

[PageAuthorize(typeof(ProjectRow))]
public class ProjectPage : Controller
{
    [Route("Students/Project")]
    public ActionResult Index()
    {
        return this.GridPage("@/Students/Project/ProjectPage",
            ProjectRow.Fields.PageTitle());
    }
}