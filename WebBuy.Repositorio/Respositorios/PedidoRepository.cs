using System;
using System.Collections.Generic;
using System.Text;
using WebBuy.Dominio.Entidades;
using WebBuy.Dominio.Interfaces;
using WebBuy.Repositorio.Contexto;

namespace WebBuy.Repositorio.Respositorios
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(Context context) : base(context)
        {
        }
    }
}
