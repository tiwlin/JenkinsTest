using SinglePageWeb.WcfTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SinglePageWeb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserView()
        {
            IUserService service = new UserServiceClient();
            service.GetData(1);

            return View();
        }
    }
}
