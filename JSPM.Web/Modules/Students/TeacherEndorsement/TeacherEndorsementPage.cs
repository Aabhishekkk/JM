using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Students.Pages;

[PageAuthorize(typeof(TeacherEndorsementRow))]
public class TeacherEndorsementPage : Controller
{
    [Route("Students/TeacherEndorsement")]
    public ActionResult Index()
    {
        return this.GridPage("@/Students/TeacherEndorsement/TeacherEndorsementPage",
            TeacherEndorsementRow.Fields.PageTitle());
    }
}