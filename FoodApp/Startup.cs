using Microsoft.Owin;
using Owin;
using System;
using System.Diagnostics;
using System.Globalization;

[assembly: OwinStartupAttribute(typeof(FoodApp.Startup))]
namespace FoodApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            if (Debugger.IsAttached)
                CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            CultureInfo.CurrentUICulture= CultureInfo.GetCultureInfo("en-US");
            ConfigureAuth(app);
        
        }
    }
}
