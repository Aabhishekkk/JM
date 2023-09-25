using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Jobs.Pages;

[PageAuthorize(typeof(JobsOpeningsRow))]
public class JobsOpeningsPage : Controller
{
    [Route("Jobs/JobsOpenings")]
    public ActionResult Index()
    {
        return this.GridPage("@/Jobs/JobsOpenings/JobsOpeningsPage",
            JobsOpeningsRow.Fields.PageTitle());
    }
}