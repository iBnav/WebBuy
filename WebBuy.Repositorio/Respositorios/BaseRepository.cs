using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebBuy.Dominio.Interfaces;
using WebBuy.Repositorio.Contexto;

namespace WebBuy.Repositorio.Respositorios
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        protected readonly Context Context;
        public BaseRepository(Context context)
        {
            Context = context;
        }
        public void Adicionar(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
            Context.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            Context.Remove(entity);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
