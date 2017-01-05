using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VocabExpander.Startup))]
namespace VocabExpander
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
