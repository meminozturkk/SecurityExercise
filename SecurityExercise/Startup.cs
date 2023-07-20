using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityExercise.Startup))]
namespace SecurityExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
