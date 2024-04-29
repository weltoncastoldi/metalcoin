using MetalCoin.Domain.Abstracts;
using MetalCoin.Domain.Enums;

namespace MetalCoin.Domain.Entities
{
    public class Usuario : Entidade
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoPerfil Perfil { get; set; }
    }
}
