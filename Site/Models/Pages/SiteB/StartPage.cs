using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Site.Models.Pages.SiteB
{
    [ContentType(DisplayName = "Start page", GUID = "188b3352-ddb8-47d7-b3bd-00b54ac2864e", Description = "", GroupName = "SiteB")]
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