using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models.Entities;
using WebApplication2.Models.IRepositories;
using WebApplication2.Models.Repositories;

namespace WebApplication2.Models.Factory
{
    public class FactoryRepositorios
    {
        protected BdContext repositorios { get; set; }

        public FactoryRepositorios()
        {
            this.repositorios = new BdContext();
        }

        public DbSet<Chamado> GetRepositorioChamado()
        {
            return this.repositorios.chamados;
        }

        public DbSet<Cliente> GetRepositorioCliente()
        {
            return this.repositorios.clientes;
        }

        public DbSet<Funcionario> GetRepositorioFuncionario()
        {
            return this.repositorios.funcionarios;
        }

        public DbSet<Status> GetRepositorioStatus()
        {
            return this.repositorios.statuses;
        }

        public void SaveChangesRepositorios()
        {
            this.repositorios.SaveChanges();
        }


    }
}