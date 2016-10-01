using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.Entities
{
    public class Funcionario
    {
        [Key]
        public int id { get; set; }
        public string cpf { get; set; }
        public string password { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }

        public virtual ICollection<Chamado> chamados { get; set; }

        public Funcionario(string cpf,string password, string nome, string teleone)
        {
            this.cpf = cpf;
            this.password = password;
            this.nome = nome;
            this.telefone = telefone;
        }
    }
}