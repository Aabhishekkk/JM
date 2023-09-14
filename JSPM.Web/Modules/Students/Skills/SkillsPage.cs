using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Students.Pages;

[PageAuthorize(typeof(SkillsRow))]
public class SkillsPage : Controller
{
    [Route("Students/Skills")]
    public ActionResult Index()
    {
        return this.GridPage("@/Students/Skills/SkillsPage",
            SkillsRow.Fields.PageTitle());
    }
}