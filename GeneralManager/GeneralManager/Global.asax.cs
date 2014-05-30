using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using GeneralManager.Models;
using GeneralManager.Filters;
using System.Web.Http.Filters;

namespace GeneralManager
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			RegisterWebApiFilters(GlobalConfiguration.Configuration.Filters);
			AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

		private static void RegisterWebApiFilters(HttpFilterCollection filters)
		{
			filters.Add(new CheckModelForNullAttribute());
			filters.Add(new ValidateModelFilterAttribute());
		}
    }
}
