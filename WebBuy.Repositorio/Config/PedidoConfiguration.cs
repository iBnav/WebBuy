﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebBuy.Dominio.Entidades;

namespace WebBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder
                .Property(p => p.DataPedido)
                .IsRequired();
            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired();
            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(10);
            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired();
            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(p => p.NumeroEndereco)
                .IsRequired();

            builder.Ignore(p => p._mensagensValidacao);
        }
    }
}
