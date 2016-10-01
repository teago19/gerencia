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
        private static Fachada singletonFachada;

        private FactoryRepositorios factory;

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
                if(singletonFachada == null)
                {
                    singletonFachada = new Fachada();
                }
                return singletonFachada;
            }
        }
    }
}