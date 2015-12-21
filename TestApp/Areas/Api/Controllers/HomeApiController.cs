using System;
using System.Web.Http;

namespace TestApp.Areas.Api.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeApiController : ApiController
    {
        [HttpGet, Route("")]
        public string Get()
        {
            return "work";
        }

        [HttpPost, Route("")]
        public object Post(Model model)
        {
            return model;
        }
    }

    public class Model
    {
        public DateTime Date { get; set; }
    }
}
