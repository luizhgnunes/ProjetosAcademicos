using SmallRoadWeb.DAL;
using SmallRoadWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace SmallRoadWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private static bool logado;

        public static bool Logado
        {
            get { return logado; }
            set { logado = value; }
        }

        public string LogadoSession
        {
            get { return Session["Logado"].ToString(); }
            set { Session["Logado"] = value; }
        }

        // GET: Usuario
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
                usu.Nome = System.Web.HttpContext.Current.Session["NomeUsuario"].ToString();
                usu.TipoUsuario = Convert.ToChar(System.Web.HttpContext.Current.Session["TipoUsuario"]);
                return Json(usu, JsonRequestBehavior.AllowGet); ;
            }
            return null;
        }

        [HttpGet]
        public void Deslogar()
        {
            FormsAuthentication.SignOut();
            System.Web.HttpContext.Current.Session.Abandon();
            Response.Redirect("~/Home/");
        }
    }
}