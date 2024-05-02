using MetalCoin.Domain.Entities;
using MetalCoin.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetalCoin.Infra.SqlServer.EfCore.Mappings
{
    internal class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome)
                .IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Email)
                .IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Senha)
                .IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Perfil)
                .IsRequired().HasColumnType("int");


            builder.HasData(
                new Usuario
                {
                    Id = Guid.NewGuid(),
                    Nome = "Administrador",
                    Senha = "abc123",
                    Email = "admin@metalcoin.com.br",
                    Perfil = TipoPerfil.Administrador
                },
                new Usuario
                {
                    Id = Guid.NewGuid(),
                    Nome = "Usuário Comum",
                    Senha = "abc123",
                    Email = "usuario@metalcoin.com.br",
                    Perfil = TipoPerfil.Usuario
                    
                }
            );
        }
    }
}