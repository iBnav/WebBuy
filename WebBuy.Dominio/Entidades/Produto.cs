using System;
using System.Collections.Generic;
using System.Text;

namespace WebBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Descrição de produto inválida");
        }
    }
}
