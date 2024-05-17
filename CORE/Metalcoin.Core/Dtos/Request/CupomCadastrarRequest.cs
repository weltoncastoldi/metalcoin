using Metalcoin.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Request
{
    public class CupomCadastrarRequest
    {
        [Required(ErrorMessage = "Código é obrigátorio")]
        public int CodigoCupom { get; set; }

        [Required(ErrorMessage = "Descrição é obrigátorio")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Valor Desconto é obrigátorio")]
        public int ValorDesconto { get; set; }

        [Required(ErrorMessage = "Tipo de Desconto é obrigátorio")]
        public TipoDesconto TipoDesconto { get; set; }
        [Required(ErrorMessage = "Data de Validade é obrigátorio")]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "Quantidade de Cupons Liberados é obrigátorio")]
        public int QuantidadeCuponsLiberados { get; set; }

        [Required(ErrorMessage = "Quantidade de Cupons Usados é obrigátorio")]
        public int QuantidadeCuponsUsados { get; set; }

        [Required(ErrorMessage = "Tipo de Status é obrigátorio")]
        public TipoStatus TipoStatus { get; set; }
    }
}
