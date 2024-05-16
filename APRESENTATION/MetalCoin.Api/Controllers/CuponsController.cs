using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    public class CuponsController : ControllerBase
    {
        private readonly ICuponsRepository _cuponsRepository;
        private readonly ICupomServices _cupomServices;

        public CuponsController(ICuponsRepository cuponsRepository, ICupomServices cupomServices) {
            _cuponsRepository = cuponsRepository;
            _cupomServices = cupomServices;
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

        [HttpPost]
        [Route("cadastrar")]
        public async Task<ActionResult> CadastarCupons([FromBody] CadastrarCupunsRequest cadastrarCupuns){
            if (cadastrarCupuns == null) {
                return BadRequest("informe o cupom"); 
            }
            var response = _cupomServices.CadastrarCupons(cadastrarCupuns);
            if (response == null) {
                return BadRequest("Cupon já exixte");
            }
            return Created("cadastrar", response);
        }
        [HttpPatch]
        [Route("atualizar")]
        public async Task<ActionResult> AtualizarCupum([FromBody])


        [HttpDelete]
        [Route("deletar/{id:guid}")]
        public async Task<ActionResult> RemoverCupom(Guid id){
            if (id == Guid.Empty) {
                return BadRequest("Id não encontrado");
            }
            var response = await _cupomServices.DeletarCupons(id);
            if (!response) {
                return BadRequest("Cupum não existe");
            }
            return Ok("Cupom deletado");
        }
    }
}
