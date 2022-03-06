using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalR_Hub.Startup))]

namespace SignalR_Hub
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.Map("/signalr", map =>
			{
				var hubConfiguration = new HubConfiguration();
				hubConfiguration.EnableDetailedErrors = true;
				hubConfiguration.EnableJavaScriptProxies = true;
				map.RunSignalR(hubConfiguration);
			});
		}
	}
}
