using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Examination.Pages;

[PageAuthorize(typeof(ExamAttemptDetailsRow))]
public class ExamAttemptDetailsPage : Controller
{
    [Route("Examination/ExamAttemptDetails")]
    public ActionResult Index()
    {
        return this.GridPage("@/Examination/ExamAttemptDetails/ExamAttemptDetailsPage",
            ExamAttemptDetailsRow.Fields.PageTitle());
    }
}