using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Examination.Pages;

[PageAuthorize(typeof(ExamQuestionsRow))]
public class ExamQuestionsPage : Controller
{
    [Route("Examination/ExamQuestions")]
    public ActionResult Index()
    {
        return this.GridPage("@/Examination/ExamQuestions/ExamQuestionsPage",
            ExamQuestionsRow.Fields.PageTitle());
    }
}