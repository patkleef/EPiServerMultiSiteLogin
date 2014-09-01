using System.Web.Mvc;
using EPiServer.Web.Mvc;
using Site.Models.Pages.SiteA;

namespace Site.Controllers.SiteA
{
    /// <summary>
    /// SiteA start page controller
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
            return View("~/Views/SiteA/StartPage/Index.cshtml", currentPage);
        }
    }
}