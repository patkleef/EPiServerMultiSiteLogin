using EPiServer.Core;

namespace Site.Models.Pages
{
    /// <summary>
    /// Start page interface
    /// </summary>
    public interface IStartPageWithLoginPageReference
    {
        ContentReference LoginPage { get; set; }
    }
}
