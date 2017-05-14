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
            return notaFiscalDal.Cadastrar(notaFiscal);
        }

        [HttpPost]
        public NotaFiscal ObterRegistro(int nfNumero)
        {
            NotaFiscalDal notaFiscalDal = new NotaFiscalDal();
            return notaFiscalDal.ObterRegistro(nfNumero);
        }

        [HttpPost]
        public bool Alterar(NotaFiscal notaFiscal)
        {
            NotaFiscalDal notaFiscalDal = new NotaFiscalDal();
            return notaFiscalDal.Alterar(notaFiscal);
        }

        [HttpPost]
        public bool Deletar(int nfnumero)
        {
            NotaFiscalDal notaFiscalDal = new NotaFiscalDal();
            return notaFiscalDal.Deletar(nfnumero);
        }
    }
}