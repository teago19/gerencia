using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication2.Models.Entities;
using WebApplication2.Models.IRepositories;

namespace WebApplication2.Models.Repositories
{
    public class EntityCollectionCliente : IRepositorioCliente
    {
        private DbSet<Cliente> dbClientes;

        public EntityCollectionCliente()
        {
            this.dbClientes = Fachada.SingleTonfachada.factory.GetRepositorioCliente();
        }

        public void adicionarCliente(Cliente cliente)
        {
            this.dbClientes.Add(cliente);
            Fachada.SingleTonfachada.factory.SaveChangesRepositorios();
        }

        public Cliente buscarCliente(string cpf)
        {
            throw new NotImplementedException();
        }

        public bool existeCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool validarLogin(string cpf, string password)
        {
            throw new NotImplementedException();
        }
    }
}