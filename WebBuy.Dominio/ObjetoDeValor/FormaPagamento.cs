using System;
using System.Collections.Generic;
using System.Text;
using WebBuy.Dominio.Enumerados;

namespace WebBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool isBoleto { get {  return Id == (int)TipoFormaPagamentoEnum.Boleto; } }
        public bool isCartao { get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; } }
        public bool isDeposito { get { return Id == (int)TipoFormaPagamentoEnum.Deposito; } }
        public bool NaoFoiDefinido { get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; } }
    }
}
