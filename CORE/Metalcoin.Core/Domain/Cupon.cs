using Metalcoin.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Domain
{
    public class Cupon : Entidade
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Desconto { get; set; }
        public int QuantidadeLiberado { get; set; }
        public int QuantidadeUsado { get; set; }
        public bool Status { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
