using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Students.Pages;

[PageAuthorize(typeof(PersonalRow))]
public class PersonalPage : Controller
{
    [Route("Students/Personal")]
    public ActionResult Index()
    {
        return this.GridPage("@/Students/Personal/PersonalPage",
            PersonalRow.Fields.PageTitle());
    }
}