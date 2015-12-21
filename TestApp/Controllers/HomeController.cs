using System;
using System.Web.Mvc;
using TestApp.ViewModels;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Date = DateTime.UtcNow;
            return View(model);
        }

        public ActionResult Add(AddSomething model)
        {
            return this.RedirectToAction("Index");
        }
    }
}