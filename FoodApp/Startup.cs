using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(FoodApp.Startup))]
namespace FoodApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        
        }
    }
}
