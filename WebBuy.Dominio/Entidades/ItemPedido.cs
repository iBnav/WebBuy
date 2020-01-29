using System;
using System.Collections.Generic;
using System.Text;

namespace WebBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (Quantidade <= 0)
                AdicionarCritica("Quantidade de produto inválida");                
        }
    }
}
