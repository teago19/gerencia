using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models.Entities;
using WebApplication2.Models.IRepositories;

namespace WebApplication2.Models.Repositories
{
    public class RepositorioFuncioarioBDR : DbContext, IRepositorioFuncionario
    {
        public DbSet<Funcionario> funcionarios { get; set; }

        void IRepositorioFuncionario.add(Funcionario funcionario)
        {
            this.funcionarios.Add(funcionario);
            this.SaveChanges();
        }
    }
}