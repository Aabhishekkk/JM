using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Syllabus.Pages;

[PageAuthorize(typeof(TopicsRow))]
public class TopicsPage : Controller
{
    [Route("Syllabus/Topics")]
    public ActionResult Index()
    {
        return this.GridPage("@/Syllabus/Topics/TopicsPage",
            TopicsRow.Fields.PageTitle());
    }
}