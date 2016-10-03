using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models.Entities;
using WebApplication2.Models.Factory;

namespace WebApplication2.Models
{
    public class Fachada
    {
        private static Fachada fachada;

        public FactoryRepositorios factory;

        private ControladorCliente controladorCliente;

        private Fachada()
        {
            this.factory = new FactoryRepositorios();
            this.controladorCliente = new ControladorCliente(this.factory);
        }
        
        public static Fachada SingletonFachada
        {
            get
            {
                if(fachada == null)
                {
                    fachada = new Fachada();
                }
                return fachada;
            }
        }

        public void CadastrarCliente(string cpf,string nome,string password, string telefone, string email,Endereco endereco)
        {
            Cliente novoCliente = new Cliente(cpf, password, nome, telefone, email, endereco);
            this.controladorCliente.cadastrarCliente(novoCliente);
            this.factory.SaveChangesRepositorios();

        }
    }
}