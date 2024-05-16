using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;
using MetalCoin.Infra.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    [ApiController]
    public class CupomController : ControllerBase
    {

        private readonly ICupomRespository _cupomRespository;
        private readonly ICupomService _cupomService;

        public CupomController(ICupomRespository cupomRespository, ICupomService cupomService)
        {
            _cupomRespository = cupomRespository;
            _cupomService = cupomService;
        }
        [HttpGet]
        [Route("obter-todos")]
        public async Task<ActionResult> ObterTodosCupons()
        {
            var todosCupons = await _cupomRespository.ObterTodos();
            return Ok(todosCupons);

        }


        [HttpGet]
        [Route("obter-todos-disponiveis")]
        public async Task<ActionResult> ObterTodosDisponiveis()
        {
            var cuponsDisponiveis = _cupomRespository.BuscarTodosDisponiveis();
            if (cuponsDisponiveis == null) return Ok("Não foi achado cupom disponivel no momento");

            return Ok(cuponsDisponiveis);
        }
        [HttpGet]
        [Route("obter-todos-indisponiveis")]
        public async Task<ActionResult> ObterTodosIndisponiveis()
        {
            var cuponsDisponiveis = _cupomRespository.BuscarTodosIndisponiveis();

            if (cuponsDisponiveis == null) return Ok("Não foi achado cupom disponivel no momento");

            return Ok(cuponsDisponiveis);

        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<ActionResult> Cadastrar([FromBody]CupomCadastraRequest cupom)
        {
            if (cupom == null) return BadRequest("Favor informar os dados do cupom");
            var response = _cupomService.CadastrarCupom(cupom);

            if (response == null) return BadRequest("Cupom já existe");

            return Created("cadastrar", response);


        }

        [HttpPut]
        [Route("atualizar")]

        public async Task<ActionResult> Atualizar([FromBody]CupomAtualizarRequest)




    }
}
