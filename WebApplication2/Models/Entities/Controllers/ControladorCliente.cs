using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models.IRepositories;
using WebApplication2.Models.Repositories;

namespace WebApplication2.Models.Entities
{
    public class ControladorCliente
    {
        private RepositorioClienteBDR dbCliente;
        public ControladorCliente(Factory.FactoryRepositorios factory)
        {
            this.dbCliente = factory.criarRepositorioCliente();
        }

        public void cadastrarCliente(Cliente cliente)
        {
            ((IRepositorioCliente)this.dbCliente).add(cliente);
        }
    }
}