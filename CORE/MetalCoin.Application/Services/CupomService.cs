using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Categorias;
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
        private readonly ICupomRepository _cupomRepository;
        public CupomService(ICupomRepository repository)
        {
            _cupomRepository = repository;
        }
        public async Task<CupomResponse> AtualizarCupom(CupomAtualizarRequest cupom)
        {
            var cupomDb = await _cupomRepository.ObterPorId(cupom.Id);


            cupomDb.CodigoCupom = cupom.CodigoCupom;
            cupomDb.Descricao = cupom.Descricao;
            cupomDb.ValorDesconto = cupom.ValorDesconto;
            cupomDb.TipoDesconto = cupom.TipoDesconto;
            cupomDb.DataValidade = cupom.DataValidade;
            cupomDb.QuantidadeCuponsdLiberados = cupom.QuantidadeCuponsdLiberados;
            cupomDb.QuantidadeCuponsUsados = cupom.QuantidadeCuponsUsados;
            cupomDb.TipoStatus = cupom.TipoStatus;


            await _cupomRepository.Atualizar(cupomDb);

            var response = new CupomResponse
            {
                Id = cupomDb.Id,
                CodigoCupom = cupomDb.CodigoCupom,
                Descricao = cupomDb.Descricao,
                ValorDesconto = cupomDb.ValorDesconto,
                TipoDesconto = cupomDb.TipoDesconto,
                DataValidade = cupomDb.DataValidade,
                QuantidadeCuponsdLiberados = cupomDb.QuantidadeCuponsdLiberados,
                QuantidadeCuponsUsados = cupomDb.QuantidadeCuponsUsados,
                TipoStatus = cupomDb.TipoStatus

            };

            return response;
        }


        public async Task<CupomResponse> CadastrarCupom(CupomCadastrarRequest cupom)
        {
            var cupomExistente = await _cupomRepository.BuscarPorNome(cupom.CodigoCupom);

            if (cupomExistente != null) return null;

            var cupomEntidade = new Cupom
            {
                CodigoCupom = cupom.CodigoCupom,
                Descricao = cupom.Descricao,
                ValorDesconto = cupom.ValorDesconto,
                TipoDesconto = cupom.TipoDesconto,
                DataValidade = cupom.DataValidade,
                QuantidadeCuponsdLiberados = cupom.QuantidadeCuponsdLiberados,
                QuantidadeCuponsUsados = cupom.QuantidadeCuponsUsados,
                TipoStatus = cupom.TipoStatus
            };

            await _cupomRepository.Adicionar(cupomEntidade);

            var response = new CupomResponse
            {
                Id = cupomEntidade.Id,
                CodigoCupom = cupomEntidade.CodigoCupom,
                Descricao = cupomEntidade.Descricao,
                ValorDesconto = cupomEntidade.ValorDesconto,
                TipoDesconto = cupomEntidade.TipoDesconto,
                DataValidade = cupomEntidade.DataValidade,
                QuantidadeCuponsdLiberados = cupomEntidade.QuantidadeCuponsdLiberados,
                QuantidadeCuponsUsados = cupomEntidade.QuantidadeCuponsUsados,
                TipoStatus = cupomEntidade.TipoStatus

            };

            return response;
        }

        public Task<bool> DeletarCupom(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}


