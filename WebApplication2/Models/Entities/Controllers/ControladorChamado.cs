using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.Entities.Controllers
{
    public class ControladorChamado
    {
        private DbSet<Chamado> dbChamado;

        public ControladorChamado(Factory.FactoryRepositorios factory)
        {
            this.dbChamado = factory.GetRepositorioChamado();
        }

        public void novoChamado(Cliente cliente,string descricao)
        {
            this.dbChamado.Add(new Chamado(cliente,descricao));
            Fachada.SingleTonfachada.factory.SaveChangesRepositorios();
        }

    }
}