using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Examination.Pages;

[PageAuthorize(typeof(ExamsRow))]
public class ExamsPage : Controller
{
    [Route("Examination/Exams")]
    public ActionResult Index()
    {
        return this.GridPage("@/Examination/Exams/ExamsPage",
            ExamsRow.Fields.PageTitle());
    }
}