﻿using Metalcoin.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Metalcoin.Core.Dtos.Request
{
    public record CupomCadastraRequest
    {
        public Guid Id { get; set; }
      
        public string Codigo { get; set; }
        [Required(ErrorMessage = "Favor informar a descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Favor informar o valor do desconto")]
        public decimal ValorDesconto { get; set; }
        [Required(ErrorMessage = "Favor informar o tipo de desconto")]
        public TipoDesconto TipoDesconto { get; set; }
        [Required(ErrorMessage = "Favor informar a data de validade")]
        public DateTime DataValidade { get; set; }
        [Required(ErrorMessage = "Favor informar a quantidade que vai ser liberado")]
        public int QuantidadeLiberado { get; set; }
        [Required(ErrorMessage = "Favor informar o Status")]
        public TipoStatus Status { get; set; }
    }
}

