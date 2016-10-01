using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models.IRepositories;
using WebApplication2.Models.Repositories;

namespace WebApplication2.Models.Factory
{
    public class FactoryRepositorios
    {
        public RepositorioStatusBDR criarRepositorioStatus()
        {
            return new RepositorioStatusBDR();
        }

        public RepositorioChamadoBDR criarRepositorioChamado()
        {
            return new RepositorioChamadoBDR();
        }

        public RepositorioClienteBDR criarRepositorioCliente()
        {
            return new RepositorioClienteBDR();
        }

        public RepositorioFuncioarioBDR criarRepositorioFuncionario()
        {
            return new RepositorioFuncioarioBDR();
        }
    }
}