using Metalcoin.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Request
{
    public class CadastrarCupunsRequest
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public TipoDesconto Desconto { get; set; }
        public int QuantidadeLiberado { get; set; }
        public int QuantidadeUsado { get; set; }
        public TipoStatus Status { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
