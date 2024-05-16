using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Response
{
    public class CuponsResponse
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Desconto { get; set; }
        public DateTime DataValidade { get; set; }
        public int QuantidadeLiberado { get; set; }
        public int QuantidadeUsado { get; set; }
        public bool Status { get; set; }
    }
}
