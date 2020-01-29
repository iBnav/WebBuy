using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebBuy.Dominio.Entidades;

namespace WebBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(user => user.Id);
            builder
                .Property(user => user.Email)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(70);
            builder
                .Property(user => user.Nome)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(user => user.CPF)
                .HasMaxLength(11)
                .IsRequired();
            builder
                .Property(user => user.Senha)
                .HasMaxLength(500);
            builder
                .HasMany(user => user.Pedidos)
                .WithOne(p => p.Usuario);
            builder.Ignore(user => user._mensagensValidacao);
        }
    }
}
