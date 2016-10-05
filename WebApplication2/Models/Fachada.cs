using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models.Entities;
using WebApplication2.Models.Entities.Controllers;
using WebApplication2.Models.Factory;

namespace WebApplication2.Models
{
    public class Fachada
    {
        private static Fachada singleTonfachada;

        public FactoryRepositorios factory;

        private ControladorCliente controladorCliente;

        private ControladorChamado controladorChamado;

        private Fachada()
        {
            this.factory = new FactoryRepositorios();
            this.controladorCliente = new ControladorCliente(this.factory);
            this.controladorChamado = new ControladorChamado(this.factory);
        }

        public static Fachada SingleTonfachada
        {
            get
            {
                if(singleTonfachada == null)
                {
                    singleTonfachada = new Fachada();
                }
                return singleTonfachada;
            }
        }

        public void CadastrarCliente(string cpf,string nome,string password, string telefone, string email,Endereco endereco)
        {
            this.controladorCliente.cadastrarCliente(new Cliente(cpf, password, nome, telefone, email, endereco));

        }
        public Cliente BuscarCliente(int id)
        {
            return this.controladorCliente.buscarCliente(id);
        }

        public int EfetuarLogin(string cpf,string password)
        {
            return this.controladorCliente.EfetuarLogin(cpf, password);
        }

        public void novoChamado(int id,string descricao)
        {
            Cliente cliente = BuscarCliente(id);
            this.controladorChamado.novoChamado(cliente,descricao);
        }
    }
}