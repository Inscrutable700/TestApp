using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TestApp.DataBinding;

namespace TestApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ModelBinders.Binders.Add(typeof(DateTime), new DateTimeDataBinder());
        }

        protected void Application_BeginRequest()
        {
            CultureInfo newCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            newCulture.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
            newCulture.DateTimeFormat.ShortTimePattern = "h:m tt";
            newCulture.DateTimeFormat.LongDatePattern = "dd.MM.yyyy";
            newCulture.DateTimeFormat.LongTimePattern = "h:m tt";
            Thread.CurrentThread.CurrentCulture = newCulture;
        }
    }
}
