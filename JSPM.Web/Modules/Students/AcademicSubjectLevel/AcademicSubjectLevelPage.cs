using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Students.Pages;

[PageAuthorize(typeof(AcademicSubjectLevelRow))]
public class AcademicSubjectLevelPage : Controller
{
    [Route("Students/AcademicSubjectLevel")]
    public ActionResult Index()
    {
        return this.GridPage("@/Students/AcademicSubjectLevel/AcademicSubjectLevelPage",
            AcademicSubjectLevelRow.Fields.PageTitle());
    }
}