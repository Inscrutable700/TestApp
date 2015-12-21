using System.Web.Http;
using System.Web.Mvc;

namespace TestApp.Areas.Api
{
    public class ApiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Api";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}