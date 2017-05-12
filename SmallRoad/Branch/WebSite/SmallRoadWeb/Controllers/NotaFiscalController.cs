using SmallRoadWeb.DAL;
using SmallRoadWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmallRoadWeb.Controllers
{
    public class NotaFiscalController : Controller
    {
        // GET: NotaFiscal
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public bool Cadastrar(NotaFiscal notaFiscal)
        {
            NotaFiscalDal notaFiscalDal = new NotaFiscalDal();

            if (!notaFiscalDal.Cadastrar(notaFiscal))
                return true;
            else
                return false;
        }
    }
}