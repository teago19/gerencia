using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Endereco
    {
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public string complemento { get; set; }

        public Endereco(string logradouro,int numero,string bairro,string cidade,string cep,string complemento)
        {
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.cep = cep;
            this.complemento = complemento;
        }
        public Endereco(){ }
    }
}