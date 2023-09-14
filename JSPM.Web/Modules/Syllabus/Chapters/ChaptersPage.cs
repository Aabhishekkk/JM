using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Syllabus.Pages;

[PageAuthorize(typeof(ChaptersRow))]
public class ChaptersPage : Controller
{
    [Route("Syllabus/Chapters")]
    public ActionResult Index()
    {
        return this.GridPage("@/Syllabus/Chapters/ChaptersPage",
            ChaptersRow.Fields.PageTitle());
    }
}