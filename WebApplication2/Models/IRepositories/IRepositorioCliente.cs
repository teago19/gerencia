using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebApplication2.Models.Entities;


namespace WebApplication2.Models.IRepositories
{
    public interface IRepositorioCliente
    {
        void adicionarCliente(Cliente cliente);
        Boolean existeCliente(Cliente cliente);
        Boolean validarLogin(string cpf, string password);
        Cliente buscarCliente(string cpf);
    }
}