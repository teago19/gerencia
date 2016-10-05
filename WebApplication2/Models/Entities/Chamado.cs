using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.Entities
{
    public class Chamado
    {
        [Key]
        public int chamadoId { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }
      //  [Column(TypeName = "DateTime2")]
      //  public DateTime dataCriacao { get; set; }
      //  [Column(TypeName = "DateTime2")]
      //  public DateTime dataFechamento { get; set; }
        public Boolean urgencia { get; set; }
        public StatusChamado statusChamado { get; set; }

        public int clienteId { get; set; }
        [ForeignKey("clienteId")]
        public virtual Cliente cliente { get; set; }

        //public int funcionarioId { get; set; }
        //[ForeignKey("funcionarioId")]
        //public virtual Funcionario funcionario { get; set; }

        public virtual ICollection<Status> listaStatus { get; set; }

        public Chamado (string descricao, double preco, DateTime dataCriacao, DateTime dataFechamento, Boolean urgencia, StatusChamado statusChamado,int clienteID,int funcionarioID)
        {
            this.descricao = descricao;
            this.preco = preco;
          //  this.dataCriacao = dataCriacao;
           // this.dataFechamento = dataFechamento;
            this.urgencia = urgencia;
            this.statusChamado = statusChamado;
            this.clienteId = clienteID;
            //this.funcionarioId = funcionarioID;
        }
        public Chamado(Cliente cliente,string descricao)
        {
            this.descricao = descricao;
            this.preco = -1;
            //this.dataCriacao = DateTime.Now;
            this.statusChamado = StatusChamado.Criado;
            this.clienteId = cliente.clienteId;
        }
        public Chamado() { }


    }

    public enum StatusChamado
    {
        Criado,
        Andamento,
        Terminado,
    }
}