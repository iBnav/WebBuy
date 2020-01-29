using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebBuy.Dominio.ObjetoDeValor;

namespace WebBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public virtual ICollection<ItemPedido> ItensPedidos {get; set;}
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento{ get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (!ItensPedidos.Any())
                AdicionarCritica("Item de pedido não pode ser vazio");
            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP não pode ser nulo ou em branco");
        }
    }
}
