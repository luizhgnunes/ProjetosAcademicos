using SmallRoadWeb.DAL;
using SmallRoadWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SmallRoadWeb.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Logar(Usuario usuario)
        {
            //System.Web.HttpContext.Current.Session["Logado"] = "true";
            UsuarioDal usuarioDal = new UsuarioDal();
            if (usuarioDal.Logar(usuario))
            {
                Usuario usu = new Usuario();
                if (!MvcApplication.DEBUG_MODE)
                {
                    usu.Nome = System.Web.HttpContext.Current.Session["NomeUsuario"].ToString();
                    usu.TipoUsuario = Convert.ToChar(System.Web.HttpContext.Current.Session["TipoUsuario"]);
                }
                else
                {
                    usu.Login = usuario.Login;
                }
                return Json(usu, JsonRequestBehavior.AllowGet);
            }
            return null;
        }

        [HttpGet]
        public void Deslogar()
        {
            FormsAuthentication.SignOut();
            System.Web.HttpContext.Current.Session.Abandon();
            Response.Redirect("~/Login/");
        }
    }
}