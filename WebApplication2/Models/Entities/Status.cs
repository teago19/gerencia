using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models.Entities
{
    public class Status
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }
        public DateTime dataCriacao { get; set; }

        public int chamadoID { get; set; }
        [ForeignKey("chamadoID")]
        public virtual Chamado chamado { get; set; }

        public Status(string descricao, DateTime dataCriacao, int chamadoID)
        {
            this.descricao = descricao;
            this.dataCriacao = dataCriacao;
            this.chamadoID = chamadoID;
        }
    }
}