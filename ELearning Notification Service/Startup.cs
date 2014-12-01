using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ELearning_Notification_Service.Startup))]
namespace ELearning_Notification_Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
