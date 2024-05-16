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
    internal class CuponsMapping : IEntityTypeConfiguration<Cupom>
    {
        public void Configure(EntityTypeBuilder<Cupom> builder) {
            builder.ToTable("Cupons");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Codigo).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Descricao).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Desconto).HasColumnType("decimal(18, 0)").IsRequired();
            builder.Property(c => c.QuantidadeLiberado).HasColumnType("int").IsRequired();
            builder.Property(c => c.QuantidadeUsado).HasColumnType("int").IsRequired();
            builder.Property(c => c.Status).HasColumnType("int").IsRequired();
            builder.Property(c => c.DataValidade).HasColumnType("datetime").IsRequired();    
        }
    }
}
