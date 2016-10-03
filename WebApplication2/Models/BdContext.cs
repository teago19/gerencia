using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models.Entities;

namespace WebApplication2.Models
{
    public class BdContext : DbContext
    {
        public DbSet<Chamado> chamados { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Funcionario> funcionarios { get; set; }
        public DbSet<Status> statuses { get; set; }
    }
}