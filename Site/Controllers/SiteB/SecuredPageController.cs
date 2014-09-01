using System.Web.Mvc;
using EPiServer.Web.Mvc;
using Site.Models.Pages.SiteB;

namespace Site.Controllers.SiteB
{
    /// <summary>
    /// SiteA login page controller
    /// </summary>
    public class SecuredPageController : PageController<SecuredPage>
    {
        /// <summary>
        /// Index action
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        public ActionResult Index(SecuredPage currentPage)
        {
            return View("~/Views/SiteB/SecuredPage/Index.cshtml", currentPage);
        }
    }
}