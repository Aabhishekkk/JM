using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Examinations.Pages;

[PageAuthorize(typeof(ExamQuestionsRow))]
public class ExamQuestionsPage : Controller
{
    [Route("Examinations/ExamQuestions")]
    public ActionResult Index()
    {
        return this.GridPage("@/Examinations/ExamQuestions/ExamQuestionsPage",
            ExamQuestionsRow.Fields.PageTitle());
    }
}