﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Response
{
    public class CupomResponse
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal ValorDesconto { get; set; }
        public string TipoDesconto { get; set; }
        public DateTime DataValidade { get; set; }
        public int QuantidadeLiberado { get; set; }
        public int QuantidadeUsado { get; set; }
        public string Status { get; set; }

    }
}
