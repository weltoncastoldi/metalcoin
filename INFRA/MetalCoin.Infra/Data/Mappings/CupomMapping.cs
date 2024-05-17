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
    internal class CupomMapping : IEntityTypeConfiguration<Cupom>
    {
        public void Configure(EntityTypeBuilder<Cupom> builder)
        {
            builder.ToTable("Cupoms");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.CodigoCupom)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.ValorDesconto)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.TipoDesconto)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.DataValidade)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.QuantidadeCuponsLiberados)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.QuantidadeCuponsUsados)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.TipoStatus)
                .HasColumnType("int")
                .IsRequired();

        }
    }
}
