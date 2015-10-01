using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSmvc4.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search(string name = "French")
        {
            var message = Server.HtmlEncode(name);

            return Content(message);
        }
    }
}