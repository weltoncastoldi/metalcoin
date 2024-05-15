using Metalcoin.Core.Interfaces.Repositories;
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
        [Route("todos")]
        public async Task<ActionResult> ObterTodosCupons()
        {
            var todosCupons = await _cupomRespository.ObterTodos();
            return  Ok(todosCupons);
        }

    }
}
