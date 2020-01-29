using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebBuy.Dominio.Entidades;
using WebBuy.Dominio.ObjetoDeValor;
using WebBuy.Repositorio.Config;

namespace WebBuy.Repositorio.Contexto
{
    public class Context : DbContext
    {
        

        public DbSet<Usuario> Usuarios{ get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento{ get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classes de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() { Id = 1, Nome="Boleto", Descricao = "Forma de Pagamento - Boleto" },
                new FormaPagamento(){ Id = 2, Nome = "CartaoCredito", Descricao = "Forma de Pagamento - Cartao de Crédito" },
                new FormaPagamento(){ Id = 3, Nome = "Deposito", Descricao = "Forma de Pagamento - Depósito" }
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
