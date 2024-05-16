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
    internal class cuponsMapping : IEntityTypeConfiguration<Cupon>
    {
        public void Configure(EntityTypeBuilder<Cupon> builder) {
            builder.ToTable("Cupons");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Codigo).HasColumnType("int").IsRequired();
            builder.Property(c => c.Descricao).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Desconto).HasColumnType("double").IsRequired();
            builder.Property(c => c.QuantidadeLiberado).HasColumnType("int").IsRequired();
            builder.Property(c => c.QuantidadeUsado).HasColumnType("int").IsRequired();
            builder.Property(c => c.Status).HasColumnType("bit").IsRequired();
            builder.Property(c => c.DataValidade).HasColumnType("datetime").IsRequired();    
        }
    }
}
