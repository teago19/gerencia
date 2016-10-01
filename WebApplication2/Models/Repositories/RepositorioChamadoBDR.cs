using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models.Entities;
using WebApplication2.Models.IRepositories;

namespace WebApplication2.Models.Repositories
{
    public class RepositorioChamadoBDR : DbContext, IRepositorioChamado
    {
        public DbSet<Chamado> chamados { get; set; }

        void IRepositorioChamado.add(Chamado chamado)
        {
            this.chamados.Add(chamado);
            this.SaveChanges();
        }
    }
}