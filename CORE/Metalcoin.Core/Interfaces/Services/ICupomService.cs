﻿using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Categorias;
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
        Task<CupomResponse> CadastrarCupom(CupomCadastraRequest cupom);
        Task<CupomResponse> AtualizarCupom(CupomAtualizarRequest cupom);
        Task<bool> Deletar(Guid id);
        Task<bool> Ativar(Guid id);
        Task<bool> Desativar(Guid id);


    }
}
