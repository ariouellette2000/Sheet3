using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMemo.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        //First change in App_start and plug the phrase in the RouteConfig folder
        //This part is indicate that when a error occur the sytem goes there
        [Route("Error/Index/{id}")]
        public ActionResult Index(int id)
        {
            return View();
        }
    }
}