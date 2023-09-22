using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Examinations.Pages;

[PageAuthorize(typeof(ExamSectionsRow))]
public class ExamSectionsPage : Controller
{
    [Route("Examinations/ExamSections")]
    public ActionResult Index()
    {
        return this.GridPage("@/Examinations/ExamSections/ExamSectionsPage",
            ExamSectionsRow.Fields.PageTitle());
    }
}