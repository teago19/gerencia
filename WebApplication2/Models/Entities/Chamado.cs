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
        public int id { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime dataCriacao { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime dataFechamento { get; set; }
        public Boolean urgencia { get; set; }
        public StatusChamado statusChamado { get; set; }

        public int clienteID { get; set; }
        [ForeignKey("clienteID")]
        public virtual Cliente cliente { get; set; }

        public int funcionarioID { get; set; }
        [ForeignKey("funcionarioID")]
        public virtual Funcionario funcionario { get; set; }

        public virtual ICollection<Status> listaStatus { get; set; }

        public Chamado (string descricao, double preco, DateTime dataCriacao, DateTime dataFechamento, Boolean urgencia, StatusChamado statusChamado,int clienteID,int funcionarioID)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.dataCriacao = dataCriacao;
            this.dataFechamento = dataFechamento;
            this.urgencia = urgencia;
            this.statusChamado = statusChamado;
            this.clienteID = clienteID;
            this.funcionarioID = funcionarioID;
        }


    }

    public enum StatusChamado
    {
        Criado,
        Andamento,
        Terminado,
    }
}