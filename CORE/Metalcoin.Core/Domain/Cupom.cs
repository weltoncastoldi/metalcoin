using Metalcoin.Core.Abstracts;
using Metalcoin.Core.Enums;

namespace Metalcoin.Core.Domain
{
    public class Cupom : Entidade
    {
        public int CodigoCupom { get; set; }
        public string Descricao { get; set; }
        public int ValorDesconto { get; set; }
        public TipoDesconto TipoDesconto { get; set; }
        public DateTime DataValidade { get; set; }
        public int QuantidadeCuponsLiberados { get; set; }
        public int QuantidadeCuponsUsados { get; set; }
        public TipoStatus TipoStatus { get; set; }
    }
}
