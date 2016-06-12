using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RealTimeRSVP.App_Start.SignalRConfig))]

namespace RealTimeRSVP.App_Start
{
    public class SignalRConfig
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}