using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models.Entities;

namespace WebApplication2.Models.IRepositories
{
    public interface IRepositorioFuncionario
    {
        void add(Funcionario funcionario);
    }
}