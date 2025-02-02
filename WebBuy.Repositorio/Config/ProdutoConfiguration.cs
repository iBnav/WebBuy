﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebBuy.Dominio.Entidades;

namespace WebBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(p => p.Preco)
                .IsRequired()
                .HasColumnType("Decimal(10,2)");
            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(400);
            builder.Ignore(p => p._mensagensValidacao);
        }
    }
}
