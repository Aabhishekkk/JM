using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Master.Pages;

[PageAuthorize(typeof(SkillsRow))]
public class SkillsPage : Controller
{
    [Route("Master/Skills")]
    public ActionResult Index()
    {
        return this.GridPage("@/Master/Skills/SkillsPage",
            SkillsRow.Fields.PageTitle());
    }
}