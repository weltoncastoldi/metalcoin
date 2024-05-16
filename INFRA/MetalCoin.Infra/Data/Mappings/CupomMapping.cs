﻿using Metalcoin.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalCoin.Infra.Data.Mappings
{
    internal class CupomMapping : IEntityTypeConfiguration<Cupom>
    {
        public void Configure(EntityTypeBuilder<Cupom> builder)
        {
            builder.ToTable("Cupoms");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.CodigoCupom)
     
                .IsRequired();

            builder.Property(p => p.Descricao)
    
                .IsRequired();

            builder.Property(p => p.ValorDesconto)
        
                .IsRequired();

            builder.Property(p => p.TipoDesconto)

                .IsRequired();

            builder.Property(p => p.DataValidade)
         
                .IsRequired();

            builder.Property(p => p.QuantidadeCuponsdLiberados)

                .IsRequired();

            builder.Property(p => p.QuantidadeCuponsUsados)
        
                .IsRequired();

            builder.Property(p => p.TipoStatus)

                .IsRequired();

        }
    }
}
