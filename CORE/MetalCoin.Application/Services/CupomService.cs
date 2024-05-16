using Metalcoin.Core.Domain;
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

        public Task<CupomResponse> AtualizarCupom(CupomAtualizarRequest cupom)
        {
            var cupomDb = _cupomRepository.ObterPorId(cupom.Id);
            if (cupomDb == null)  return null;

            


            var response = new CupomResponse
            {
                
                Id = cupom.Id,
                Codigo = cupom.Codigo,
                Descricao = cupom.Descricao,
                ValorDesconto = cupom.ValorDesconto,
                TipoDesconto = cupom.TipoDesconto,
                DataValidade = cupom.DataValidade,
                QuantidadeLiberado = cupom.QuantidadeLiberado,
                Status = cupom.Status,

            };

            return response;
        }

        public async Task<CupomResponse> CadastrarCupom(CupomCadastraRequest cupom)
        {
            var verificarCupomExistente = await _cupomRepository.ObterPorId(cupom.Id);

            if (verificarCupomExistente != null) return null;


            var cupomEntidade = new Cupom
            {
                Id = cupom.Id,
                Codigo = cupom.Codigo,
                Descricao = cupom.Descricao,
                ValorDesconto = cupom.ValorDesconto,
                TipoDesconto = cupom.TipoDesconto,
                DataValidade = cupom.DataValidade,
                QuantidadeLiberado = cupom.QuantidadeLiberado,
                Status = cupom.Status,
            };


            await _cupomRepository.Adicionar(cupomEntidade);

            var response = new CupomResponse
            {
                Id = cupomEntidade.Id,
                Codigo = cupomEntidade.Codigo,
                Descricao = cupomEntidade.Descricao,
                ValorDesconto = cupomEntidade.ValorDesconto,
                TipoDesconto = cupomEntidade.TipoDesconto,
                DataValidade = cupomEntidade.DataValidade,
                QuantidadeLiberado = cupomEntidade.QuantidadeLiberado,
                QuantidadeUsado = cupomEntidade.QuantidadeUsado,
                Status = cupomEntidade.Status

            };

            return response;



        }

    }
}
