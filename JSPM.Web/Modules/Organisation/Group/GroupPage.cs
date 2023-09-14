using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace JSPM.Organisation.Pages;

[PageAuthorize(typeof(GroupRow))]
public class GroupPage : Controller
{
    [Route("Organisation/Group")]
    public ActionResult Index()
    {
        return this.GridPage("@/Organisation/Group/GroupPage",
            GroupRow.Fields.PageTitle());
    }
}