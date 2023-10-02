namespace JSPM.Common.Pages
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Web;
    using System;
    using Microsoft.AspNetCore.Mvc;



    public class HomeController : Controller
    {
        [HttpGet, Route("~/")]
        public ActionResult Index()
        {

            return View(MVC.Views.Common.Home.HomeIndex);

        }
/*
        [HttpGet, Route("~/About")]
        public ActionResult About()
        {

            //return View(MVC.Views.Common.Frontend.Home);
            return View(MVC.Views.ICAI.About);
        }
        [HttpGet, Route("~/Blog")]
        public ActionResult Blog()
        {
            return View(MVC.Views.ICAI.Blog);
        }
        [HttpGet, Route("~/BlogSingle")]
        public ActionResult BlogSingle()
        {
            return View(MVC.Views.ICAI.BlogSingle);
        }
        [HttpGet, Route("~/Contact")]
        public ActionResult Contact()
        {
            return View(MVC.Views.ICAI.Contact);
        }
        [HttpGet, Route("~/ManagingCommittee")]
        public ActionResult ManagingCommittee()
        {
            return View(MVC.Views.ICAI.ManagingCommittee);
        }
        [HttpGet, Route("~/PastChairman")]
        public ActionResult PastChairman()
        {
            return View(MVC.Views.ICAI.PastChairman);
        }
        [HttpGet, Route("~/Resources")]
        public ActionResult Resources()
        {
            return View(MVC.Views.JSPM.Resources);
        }
        [HttpGet, Route("~/TorchBearer")]
        public ActionResult TorchBearer()
        {
            return View(MVC.Views.JSPM.TorchBearer);
        }*/
    }
}
