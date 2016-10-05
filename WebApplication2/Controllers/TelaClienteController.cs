using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Models.Entities;

namespace WebApplication2.Controllers
{
    public class TelaClienteController : Controller
    {
        // GET: TelaCliente
        public ActionResult Index()
        {
            Cliente temp = Fachada.SingleTonfachada.BuscarCliente((int)Session["usuarioLogadoID"]);

            ViewBag.qtdChamadosCriados = temp.chamados.Where<Chamado>(c => c.statusChamado == StatusChamado.Criado).ToList<Chamado>().Count;
            ViewBag.qtdChamadosAndamento = temp.chamados.Where<Chamado>(c => c.statusChamado == StatusChamado.Andamento).ToList<Chamado>().Count;
            ViewBag.qtdChamadosTerminados = temp.chamados.Where<Chamado>(c => c.statusChamado == StatusChamado.Terminado).ToList<Chamado>().Count;
            return View(temp);
        }

        public ActionResult NovoChamado()
        {
            Cliente temp = Fachada.SingleTonfachada.BuscarCliente((int)Session["usuarioLogadoID"]);

            return View(temp);
        }

        [HttpPost]
        public ActionResult NovoChamado(string descricao)
        {
            try
            {
                Fachada.SingleTonfachada.novoChamado((int)Session["usuarioLogadoID"], descricao);
                return RedirectToAction("Index", "TelaCliente");
            }
            catch
            {
                return View();
            }
        }
    }
}