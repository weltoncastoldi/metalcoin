using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    [ApiController]
    public class CupomController : ControllerBase
    {
        private readonly ICuponsRepository _cuponsRepository;
        private readonly ICuponsServices _cuponsServices;

        public CupomController(ICuponsRepository cuponsRepository, ICuponsServices cuponsServices)
        {
            _cuponsRepository = cuponsRepository;
            _cuponsServices = cuponsServices;
        }

        [HttpGet]
        [Route("obter-todos-cupons")]
        public async Task<ActionResult> ObterTodosCupons()
        {
            var listarCupons = await _cuponsRepository.ObterTodos();

            if (listarCupons.Count == 0) return NoContent();

            return Ok(listarCupons);
        }


        [HttpGet]
        [Route("obter-todos-ativos")]
        public async Task<ActionResult> ObterTodosCuponsAtivos()
        {
            var listarCupons = await _cuponsRepository.BuscarCupomAtivos();


            return Ok(listarCupons);
        }
        [HttpGet]
        [Route("obter-todos-desativados")]
        public async Task<ActionResult> ObterTodosCuponsDesativados()
        {
            var listarCupons = await _cuponsRepository.BuscarCupomIndisponiveis();


            return Ok(listarCupons);
        }
        [HttpGet]
        [Route("obter/{id:guid}")]
        public async Task<ActionResult> ObterPorId(Guid id)
        {
            var categoria = await _cuponsRepository.ObterPorId(id);
            if (categoria == null) return BadRequest("Cupom não encontrado");
            return Ok(categoria);
        }


        [HttpPost]
        [Route("cadastrar-cupom")]
        public async Task<ActionResult> CadastrarCupom([FromBody] CupomCadastrarRequest cupom)
        {
            if (cupom == null) return BadRequest("Informe o nome da cupom");

            var response = await _cuponsServices.CadastrarCupom(cupom);

            if (response == null) return BadRequest("Cupom já existe");

            return Created("cadastrar", response);
        }


        [HttpPut]
        [Route("atualizar-cupom")]
        public async Task<ActionResult> AtualizarCupom([FromBody] CupomAtualizarRequest cupom)
        {
            if (cupom == null) return BadRequest("Favor informar os dados");

            var response = await _cuponsServices.AtualizaCupom(cupom);

            return Ok(response);
        }



        [HttpDelete]
        [Route("deletar/cupom/{id:guid}")]
        public async Task<ActionResult> RemoverCupom(Guid id)
        {
            if (id == Guid.Empty) return BadRequest("Favor informar os dados");

            var resultado = await _cuponsServices.DeletarCupom(id);

            if (!resultado) return BadRequest("Id inválido");

            return Ok("Cupom deletado com sucesso");
        }

        [HttpPut]
        [Route("ativar-cupom")]
        public async Task<ActionResult> AtivarCupom(Guid id)
        {
            if (id == null) return BadRequest("Favor informar os dados");
            
            var resultado = await _cuponsServices.AtivarCupom(id);

            if (!resultado) return BadRequest("Não é possivel ativar pois já está ativo");

            return Ok("Cupom ativado com sucesso");
        }

        [HttpPut]
        [Route("desativar-cupom")]
        public async Task<ActionResult> DesativarCupom(Guid id)
        {
            if (id == null) return BadRequest("Favor informar os dados");

            var resultado = await _cuponsServices.DesativarCupom(id);

            if (!resultado) return BadRequest("O cupom já está desativado");

            return Ok("Cupom desativado com sucesso");
        }
        
        [HttpPut]
        [Route("ultilizar-cupom")]
        public async Task<ActionResult> UltilizarCupom(string codigo)
        {
            if (codigo == null) return BadRequest("Favor informar o Codigo do cupom");

            var usarCupom = await _cuponsServices.UlltilizarCupom(codigo);

            if (!usarCupom) return BadRequest("Não foi possivel ultilizar cupom");

            return Ok("Cupom Ultilizado com sucesso!");

            
        }


    }
}
