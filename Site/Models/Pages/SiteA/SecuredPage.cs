using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Site.Models.Pages.SiteA
{
    [ContentType(DisplayName = "Secured page", GUID = "84d62444-67ec-4506-93bc-3dab57aa6f40", Description = "", GroupName = "SiteA")]
    public class SecuredPage : PageData
    {

    }
}