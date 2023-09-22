using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Examinations.Pages;

[PageAuthorize(typeof(ExamsRow))]
public class ExamsPage : Controller
{
    [Route("Examinations/Exams")]
    public ActionResult Index()
    {
        return this.GridPage("@/Examinations/Exams/ExamsPage",
            ExamsRow.Fields.PageTitle());
    }
}