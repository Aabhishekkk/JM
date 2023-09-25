using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Examination.Pages;

[PageAuthorize(typeof(ExamSectionsRow))]
public class ExamSectionsPage : Controller
{
    [Route("Examination/ExamSections")]
    public ActionResult Index()
    {
        return this.GridPage("@/Examination/ExamSections/ExamSectionsPage",
            ExamSectionsRow.Fields.PageTitle());
    }
}