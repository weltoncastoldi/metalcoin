using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalCoin.Application.Services
{
    public class CupomService : ICupomService
    {
        private readonly ICupomRespository _cupomRepository;
        public CupomService(ICupomRespository cupom)
        {
            _cupomRepository = cupom;
        }
        public async Task<CupomResponse> CadastrarCategoria(CupomCadastraRequest cupom)
        {
            
            //var cadastrarCupom  = await  _cupomRepository.
        }
    }
}
