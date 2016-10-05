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
    public class TelaLoginController : Controller
    {
        // GET: TelaHome
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string cpf, string password)
        {
            try
            {
                int temp = Fachada.SingleTonfachada.EfetuarLogin(cpf, password);
                Session["usuarioLogadoID"] = temp;
                return RedirectToAction("Index", "TelaCliente");
            }
            catch
            {
                return RedirectToAction("CadastrarCliente", "TelaCadastroCliente");
            }
        }
    }
}