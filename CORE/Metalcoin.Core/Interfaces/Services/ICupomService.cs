﻿using Metalcoin.Core.Dtos.Categorias;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Interfaces.Services
{
    public interface ICupomService
    {
        Task<CupomResponse> CadastrarCupom(CupomCadastrarRequest cupom);
        Task<CupomResponse> AtualizarCupom(CupomAtualizarRequest cupom);
        Task<bool> DeletarCupom(Guid id);
    }
}
