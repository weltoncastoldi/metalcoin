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
    public class CupomServices : ICupomServices
    {
        private readonly ICuponsRepository _CupomRepository;
        public CupomServices(ICuponsRepository repository) {
            _CupomRepository = repository;
        }
        public async Task<CuponsResponse> CadastrarCupons(CadastrarCupunsRequest cupom) {

            var cupomExiste = await _CupomRepository.BuscarPorNome(cupom.Codigo);
              
            if (cupomExiste != null) {
                return null;
            }
           var cupomEntidade = new Cupom
           {
               Codigo = cupom.Codigo,
               Descricao = cupom.Descricao,
               Desconto = cupom.Desconto,
               QuantidadeLiberado = cupom.QuantidadeLiberado,
               QuantidadeUsado = cupom.QuantidadeUsado,
               Status = cupom.Status,
               DataValidade = cupom.DataValidade
           };
           
            await _CupomRepository.Adicionar(cupomEntidade);

            var response = new CuponsResponse
            {
                Id = cupomEntidade.Id,
                Codigo = cupomEntidade.Codigo,
                Desconto = cupomEntidade.Desconto,
                Descricao = cupomEntidade.Descricao,
                QuantidadeLiberado = cupomEntidade.QuantidadeLiberado,
                QuantidadeUsado = cupomEntidade.QuantidadeUsado,
                Status = cupomEntidade.Status,
                DataValidade = cupomEntidade.DataValidade,
            };
            return response;
        }

        public async Task<bool> DeletarCupons(Guid id)
        {
           var cupom = await _CupomRepository.ObterPorId(id);
            if (cupom == null) {
                return false;
            }
            await _CupomRepository.Remover(id);
            return true;
        }
    }
}
