using System;
using WebBuy.Dominio.Entidades;
using WebBuy.Dominio.Interfaces;
using WebBuy.Repositorio.Contexto;

namespace WebBuy.Repositorio.Respositorios
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(Context context) : base(context)
        {

        }
    }
}
