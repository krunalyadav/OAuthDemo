using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAuthDemo.Startup))]
namespace OAuthDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var cookieOptions = new CookieAuthenticationOptions
            {
                LoginPath = new PathString("/Account/Login")
            };
            app.UseCookieAuthentication(cookieOptions);
        }
    }
}