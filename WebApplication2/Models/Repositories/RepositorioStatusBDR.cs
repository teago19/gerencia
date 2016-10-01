using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models.Entities;
using WebApplication2.Models.IRepositories;

namespace WebApplication2.Models.Repositories
{
    public class RepositorioStatusBDR : DbContext, IRepositorioStatus
    {
        public DbSet<Status> statuses { get; set; }

        void IRepositorioStatus.add(Status status)
        {
            this.statuses.Add(status);
            this.SaveChanges();
        }

    }
}