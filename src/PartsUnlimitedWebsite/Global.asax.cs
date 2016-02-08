using System;
using System.Data.Entity;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using PartsUnlimited.Utils;
using Unity.Mvc4;
using Microsoft.ApplicationInsights.Extensibility;
using PartsUnlimited.appInsights;

namespace PartsUnlimited
{
    public class Global : HttpApplication
    {
        internal static IUnityContainer UnityContainer;

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();

            Database.SetInitializer(new PartsUnlimitedDbInitializer());

            UnityContainer = UnityConfig.BuildContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(UnityContainer));

            RouteConfig.RegisterRoutes(RouteTable.Routes);
            WebApiConfig.RegisterWebApi(GlobalConfiguration.Configuration, UnityContainer);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            TelemetryConfiguration.Active.TelemetryInitializers.Add(new TelemetryInitializer());
            TelemetryConfiguration.Active.ContextInitializers.Add(new TelemetryContextInitializer());
        }
    }
}