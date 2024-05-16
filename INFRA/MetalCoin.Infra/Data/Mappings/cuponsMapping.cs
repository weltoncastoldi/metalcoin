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
    internal class cuponsMapping : IEntityTypeConfiguration<Cupons>
    {
        public void Configure(EntityTypeBuilder<Cupons> builder) {
            builder.ToTable("Cupons");


        }
    }
}
