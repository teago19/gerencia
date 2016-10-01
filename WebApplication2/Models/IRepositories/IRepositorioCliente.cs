using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebApplication2.Models.Entities;


namespace WebApplication2.Models.IRepositories
{
    public interface IRepositorioCliente
    {
        void add(Cliente cliente);
    }
}