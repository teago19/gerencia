using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication2.Models.Entities;
using WebApplication2.Models.IRepositories;

namespace WebApplication2.Models.Repositories
{
    public class RepositorioClienteBDR : DbContext, IRepositorioCliente
    {
        public DbSet<Cliente> clientes { get; set; }

        void IRepositorioCliente.add(Cliente cliente)
        {
            this.clientes.Add(cliente);
            this.SaveChanges();
        }
    }
}