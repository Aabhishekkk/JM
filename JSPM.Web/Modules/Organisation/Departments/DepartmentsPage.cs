using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Organisation.Pages;

[PageAuthorize(typeof(DepartmentsRow))]
public class DepartmentsPage : Controller
{
    [Route("Organisation/Departments")]
    public ActionResult Index()
    {
        return this.GridPage("@/Organisation/Departments/DepartmentsPage",
            DepartmentsRow.Fields.PageTitle());
    }
}