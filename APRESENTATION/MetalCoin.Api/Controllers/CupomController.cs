using Metalcoin.Core.Dtos.Categorias;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    [ApiController]
    public class CupomController : ControllerBase
    {

        private readonly ICupomRepository _cupomRepository;
        private readonly ICupomService _cupomService;

        public CupomController(ICupomRepository cupomRepository, ICupomService cupomService)
        {
            _cupomRepository = cupomRepository;
            _cupomService = cupomService;
        }

        [HttpGet]
        [Route("TodosCupoms")]
        public async Task<ActionResult> ObterTodosCupons()
        {
            var listaCupons = await _cupomRepository.ObterTodos();

            if (listaCupons.Count == 0) return NoContent();

            return Ok(listaCupons);
        }


        [HttpGet]
        [Route("ObterUmCupons")]
        public async Task<ActionResult> ObterUmCupom(Guid id)
        {
            var cupom = await _cupomRepository.ObterPorId(id);
            if (cupom == null) return BadRequest("Cupom não encontrada");
            return Ok(cupom);
        }


        [HttpPost]
        [Route("CadastrarCupons")]
        public async Task<ActionResult> CadastrarCupom([FromBody] CupomCadastrarRequest cupom)
        {
            if (cupom == null) return BadRequest("Informe o nome da categoria");

            var response = await _cupomService.CadastrarCupom(cupom);

            if (response == null) return BadRequest("Categoria já existe");

            return Created("cadastrar", response);
        }


        [HttpPut]
        [Route("AtualizarCupons")]
        public async Task<ActionResult> AtualizarCupom([FromBody] CupomAtualizarRequest cupom)
        {
            if (cupom == null) return BadRequest("Nenhum valor chegou na API");

            var response = await _cupomService.AtualizarCupom(cupom);

            return Ok(response);
        }

        [HttpDelete]
        [Route("deletarCupons")]
        public async Task<ActionResult> RemoverCategoria(Guid id)
        {
            if (id == Guid.Empty) return BadRequest("Id não informado");

            var resultado = await _cupomService.DeletarCupom(id);

            if (!resultado) return BadRequest("A categoria que está tentando deletar não existe");

            return Ok("Categoria deletada com sucesso");
        }
    }
}
