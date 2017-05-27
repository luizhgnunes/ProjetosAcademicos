using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmallRoadWeb.Controllers
{
    public class RoteiroController : Controller
    {
        // GET: Roteiro
        public ActionResult Index()
        {
            if (!MvcApplication.DEBUG_MODE && (Session == null || Session.Count == 0))
            {
                Response.Redirect("~/Login/");
                return null;
            }
            return View();
        }
    }
}