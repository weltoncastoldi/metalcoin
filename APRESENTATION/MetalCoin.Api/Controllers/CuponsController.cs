using Metalcoin.Core.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    public class CuponsController : ControllerBase
    {
        private readonly ICuponsRepository _cuponsRepository;

        public CuponsController(ICuponsRepository cuponsRepository) {
            _cuponsRepository = cuponsRepository;
        }
        [HttpGet]
        [Route("todos")]
        public async Task<ActionResult> ObterTodosCupons() {
            var listaCupons = await _cuponsRepository.ObterTodos();
            
            if (listaCupons.Count == 0) {
                return NoContent();
            }

            return Ok(listaCupons);
        }
    }
}
