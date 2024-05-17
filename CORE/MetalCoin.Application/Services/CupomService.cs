using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;
using Metalcoin.Core.Enums;
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

        


        public async Task<bool> Ativar(Guid id)
        {
            var cupomDb = await _cupomRepository.ObterPorId(id);
            if (cupomDb == null ) return false;

            cupomDb.Status = TipoStatus.Ativo;

            return true;
        }
        public async Task<bool> Desativar(Guid id)
        {
            var cupomDb = await _cupomRepository.ObterPorId(id);
            if (cupomDb == null) return false;

            cupomDb.Status = TipoStatus.Desativado;

            return true;
        }

        public async Task<CupomResponse> AtualizarCupom(CupomAtualizarRequest cupom)
        {
            
            var cupomDb = await _cupomRepository.ObterPorId(cupom.Id);
            if (cupomDb == null)  return null;

            cupomDb.Codigo = cupom.Codigo;
            cupomDb.Descricao = cupom.Descricao;
            cupomDb.ValorDesconto = cupom.ValorDesconto;
            cupomDb.TipoDesconto = cupom.TipoDesconto;
            cupomDb.DataValidade = cupom.DataValidade;
            cupomDb.QuantidadeLiberado = cupom.QuantidadeLiberado;
            cupomDb.Status = cupom.Status;

            var response = new CupomResponse
            {
                
                Id = cupomDb.Id,
                Codigo = cupomDb.Codigo,
                Descricao = cupomDb.Descricao,
                ValorDesconto = cupomDb.ValorDesconto,
                TipoDesconto = cupomDb.TipoDesconto,
                DataValidade = cupomDb.DataValidade,
                QuantidadeLiberado = cupomDb.QuantidadeLiberado,
                Status = cupomDb.Status,

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

        public async Task<bool> Deletar(Guid id)
        {
            var cupomDb = _cupomRepository.ObterPorId(id);
            if (cupomDb == null) { return false; }

            await _cupomRepository.Remover(id);
            return true;
        }
    }
}
