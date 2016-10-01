using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models.Entities;
using WebApplication2.Models.Repositories;

namespace WebApplication2.Controllers
{
    public class TelaCadastroClienteController : Controller
    {
        private RepositorioClienteBDR db = new RepositorioClienteBDR();

        // GET: TelaCadastroCliente
        public string CadastrarCliente()
        {
            return "ROUTE CADASTRAR CLIENTE OK!";
        }
    }
}
