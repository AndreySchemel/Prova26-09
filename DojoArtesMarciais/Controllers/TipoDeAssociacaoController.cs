using DojoArtesMarciais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DojoArtesMarciais.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {
        private ApplicationDbContext _context;

        public TipoDeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: /Faixa/
        public ActionResult Index()
        {
            var tipodeassociacao = _context.TiposDeAssociacao.ToList();
            return View(tipodeassociacao);
        }

        public ActionResult Details(int id)
        {
            var tipodeassociacao = _context.TiposDeAssociacao.SingleOrDefault(a => a.Id == id);

            if (tipodeassociacao == null)
                return HttpNotFound();

            return View(tipodeassociacao);
        }
    }
}