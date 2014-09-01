using System.Web.Mvc;
using EPiServer.Web.Mvc;
using Site.Models.Pages.SiteB;

namespace Site.Controllers.SiteB
{
    /// <summary>
    /// SiteB start page controller
    /// </summary>
    public class StartPageController : PageController<StartPage>
    {
        /// <summary>
        /// Index action
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        public ActionResult Index(StartPage currentPage)
        {
            return View("~/Views/SiteB/StartPage/Index.cshtml", currentPage);
        }
    }
}