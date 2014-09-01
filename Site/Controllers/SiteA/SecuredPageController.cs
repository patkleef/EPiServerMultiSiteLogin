using System.Web.Mvc;
using EPiServer.Web.Mvc;
using Site.Models.Pages.SiteA;

namespace Site.Controllers.SiteA
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
            return View("~/Views/SiteA/SecuredPage/Index.cshtml", currentPage);
        }
    }
}