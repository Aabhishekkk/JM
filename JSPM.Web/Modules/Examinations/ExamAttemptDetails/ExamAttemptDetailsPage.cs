using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Examinations.Pages;

[PageAuthorize(typeof(ExamAttemptDetailsRow))]
public class ExamAttemptDetailsPage : Controller
{
    [Route("Examinations/ExamAttemptDetails")]
    public ActionResult Index()
    {
        return this.GridPage("@/Examinations/ExamAttemptDetails/ExamAttemptDetailsPage",
            ExamAttemptDetailsRow.Fields.PageTitle());
    }
}