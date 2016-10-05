using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models.IRepositories;
using WebApplication2.Models.Repositories;

namespace WebApplication2.Models.Entities
{
    public class ControladorCliente
    {
        private DbSet<Cliente> dbCliente;

        public ControladorCliente(Factory.FactoryRepositorios factory)
        {
            this.dbCliente = factory.GetRepositorioCliente();
        }

        public void cadastrarCliente(Cliente cliente)
        {
            this.dbCliente.Add(cliente);
            Fachada.SingleTonfachada.factory.SaveChangesRepositorios();
        }

        public Cliente buscarCliente(int id)
        {
            return this.dbCliente.Find(id);
        }

        public int EfetuarLogin(string cpf, string password)
        {
            int temp = this.dbCliente.Where<Cliente>(c => c.cpf == cpf && c.password == password).FirstOrDefault<Cliente>().clienteId;
            return temp;
        }
    }
}