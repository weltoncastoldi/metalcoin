using Metalcoin.Core.Interfaces.Repositories;
using MetalCoin.Infra.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    [ApiController]
    public class CupomController : ControllerBase
    {

        private readonly ICupomRespository _cupomRespository;

        public CupomController(ICupomRespository cupomRespository)
        {
            _cupomRespository = cupomRespository;
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




    }
}
