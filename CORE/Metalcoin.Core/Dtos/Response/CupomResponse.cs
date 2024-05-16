using Metalcoin.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Response
{
    public class CupomResponse
    {
        public Guid Id { get; set; }
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
