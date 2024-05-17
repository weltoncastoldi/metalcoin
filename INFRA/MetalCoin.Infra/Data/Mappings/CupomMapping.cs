using Metalcoin.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalCoin.Infra.Data.Mappings
{
    internal class CupomMapping
    {
        public void Configure(EntityTypeBuilder<Cupom> builder)
        {
            builder.ToTable("Cupom");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Codigo)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.ValorDesconto)
                .HasColumnType("decimal(18, 0)")
                .IsRequired();

            builder.Property(p => p.TipoDesconto)
                .HasColumnType("int")
                .IsRequired();
            builder.Property(p => p.DataValidade)
                .HasColumnType("Datetime")
                .IsRequired();
            builder.Property(p => p.QuantidadeLiberado)
                .HasColumnType("int")
                .IsRequired();
            builder.Property(p => p.QuantidadeUsado)
                .HasColumnType("int")
                .IsRequired();
            builder.Property(p => p.Status)
                .HasColumnType("int")
                .IsRequired();

        }
    }
}
