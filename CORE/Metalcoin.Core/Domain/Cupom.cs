using Metalcoin.Core.Abstracts;
using Metalcoin.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Domain
{
    public class Cupom : Entidade
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal ValorDesconto { get; set; }
        public TipoDesconto TipoDesconto { get; set; }
        public DateTime DataValidade { get; set; }
        public int QuantidadeLiberado { get; set; }
        public int QuantidadeUsado { get; set; }
        public TipoStatus Status { get; set; }
    }
}
