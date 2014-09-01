using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Site.Models.Pages.SiteA
{
    [ContentType(DisplayName = "Start page", GUID = "48a7a88e-9e25-4db7-90c8-333bc9830784", Description = "", GroupName = "SiteA")]
    public class StartPage : PageData, IStartPageWithLoginPageReference
    {
        [Display(
            Name = "Login page",
            Description = "Reference to the login page",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentReference LoginPage { get; set; }
    }
}