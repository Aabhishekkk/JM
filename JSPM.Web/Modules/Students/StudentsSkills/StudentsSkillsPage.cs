using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Students.Pages;

[PageAuthorize(typeof(StudentsSkillsRow))]
public class StudentsSkillsPage : Controller
{
    [Route("Students/StudentsSkills")]
    public ActionResult Index()
    {
        return this.GridPage("@/Students/StudentsSkills/StudentsSkillsPage",
            StudentsSkillsRow.Fields.PageTitle());
    }
}