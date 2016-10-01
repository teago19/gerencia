using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.Entities
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public string cpf { get; set; }
        public string password { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public Endereco endereco { get; set; }

        public virtual ICollection<Chamado> chamados { get; set; }

        public Cliente(string cpf, string password, string nome, string telefone, string email, Endereco endereco)
        {
            this.cpf = cpf;
            this.password = password;
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.endereco = endereco;

        }

    }
}