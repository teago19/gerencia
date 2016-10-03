using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Models.Repositories;

namespace WebApplication2.Controllers
{
    public class TelaCadastroClienteController : Controller
    {

        // GET: TelaCadastroCliente/Create
        public ActionResult CadastrarCliente()
        {
            return View();
        }

        // POST: TelaCadastroCliente/Create
        [HttpPost]
        public ActionResult CadastrarCliente(string nome, string telefone, string email, string password,string cpf)
        {
            try
            {
                Fachada.SingleTonfachada.CadastrarCliente(cpf, nome, password, telefone, email, new Endereco("c", 3, "c", "c", "3", "3"));

                return RedirectToRoute("");
            }
            catch
            {
                return View();
            }
        }
    }
}
