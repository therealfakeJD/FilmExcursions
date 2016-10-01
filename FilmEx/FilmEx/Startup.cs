using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilmEx.Startup))]
namespace FilmEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
