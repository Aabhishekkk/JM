using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Syllabus.Pages;

[PageAuthorize(typeof(SubjectsRow))]
public class SubjectsPage : Controller
{
    [Route("Syllabus/Subjects")]
    public ActionResult Index()
    {
        return this.GridPage("@/Syllabus/Subjects/SubjectsPage",
            SubjectsRow.Fields.PageTitle());
    }
}