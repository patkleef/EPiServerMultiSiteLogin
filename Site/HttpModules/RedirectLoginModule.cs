using System;
using System.Web;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using Site.Models.Pages;

namespace Site.HttpModules
{
    /// <summary>
    /// This module redirects the user to the login page that belongs to the current visiting website
    /// </summary>
    public class RedirectLoginModule : IHttpModule
    {
        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {

        }

        /// <summary>
        /// Init method
        /// </summary>
        /// <param name="context"></param>
        public void Init(HttpApplication context)
        {
            context.BeginRequest += Application_BeginRequest;
        }

        /// <summary>
        /// Application begin request
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void Application_BeginRequest(Object source, EventArgs e)
        {
            var application = (HttpApplication)source;
            var context = application.Context;

            if (!string.IsNullOrEmpty(context.Request.QueryString["ReturnUrl"])) // User is being redirected so make sure the right login page is loaded
            {
                var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
                var pageRouteHelper = ServiceLocator.Current.GetInstance<PageRouteHelper>();
                var urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();

                if (!ContentReference.IsNullOrEmpty(ContentReference.StartPage))
                {
                    var startPage = contentLoader.Get<PageData>(ContentReference.StartPage);
                    if (startPage != null && startPage is IStartPageWithLoginPageReference)
                    {
                        var startPageWithLoginReference = (IStartPageWithLoginPageReference) startPage;
                        if (!ContentReference.IsNullOrEmpty(startPageWithLoginReference.LoginPage) &&
                            startPageWithLoginReference.LoginPage.ID != pageRouteHelper.PageLink.ID)
                            // Check if user isn't already on the login page so an infinite redirect loop is prevented
                        {
                            var url = new UrlBuilder(urlResolver.GetUrl(startPageWithLoginReference.LoginPage));
                            url.QueryCollection.Add("ReturnUrl", context.Request.QueryString["ReturnUrl"]);

                            context.Response.Redirect(url.ToString());
                        }
                    }
                }
            }
        }
    }
}