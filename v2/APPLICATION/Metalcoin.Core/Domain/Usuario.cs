using Metalcoin.Core.Abstracts;
using Metalcoin.Core.Enums;

namespace Metalcoin.Core.Domain
{
    public class Usuario : Entidade
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoPerfil Perfil { get; set; }
    }
}
