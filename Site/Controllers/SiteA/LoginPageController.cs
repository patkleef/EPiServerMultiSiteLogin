using System.Web.Mvc;
using EPiServer.Web.Mvc;
using Site.Models.Pages.SiteA;

namespace Site.Controllers.SiteA
{
    /// <summary>
    /// SiteA login page controller
    /// </summary>
    public class LoginPageController : PageController<LoginPage>
    {
        /// <summary>
        /// Index action
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        public ActionResult Index(LoginPage currentPage)
        {
            return View("~/Views/SiteA/LoginPage/Index.cshtml", currentPage);
        }
    }
}