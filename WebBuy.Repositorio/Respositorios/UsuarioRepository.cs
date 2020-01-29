using System;
using System.Collections.Generic;
using System.Text;
using WebBuy.Dominio.Entidades;
using WebBuy.Dominio.Interfaces;
using WebBuy.Repositorio.Contexto;

namespace WebBuy.Repositorio.Respositorios
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Context context) : base(context)
        {
        }
    }
}
