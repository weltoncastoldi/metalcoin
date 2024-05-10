using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos;
using Metalcoin.Core.Dtos.Categorias;
using Metalcoin.Core.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;
        
        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        [HttpGet]
        [Route("todos")]
        public async Task<IEnumerable<CategoriaDto>> ObterTodasCategorias()
        {
            var listaCategorias = _categoriaRepository.ObterTodos();
            return (IEnumerable<CategoriaDto>)listaCategorias;
        }


        [HttpPost]
        [Route("cadastrar")]
        public async Task<ActionResult> CadastrarCategoria(string nomeCategoria)
        {
            if (nomeCategoria == null)
            {
                return BadRequest("Informe o nome da categoria");
            }

            try
            {
                var categoria = new Categoria
                {
                    Id = Guid.NewGuid(),
                    Nome = nomeCategoria,
                    Status = true,
                    DataCadastro = DateTime.Now,
                    DataAlteracao = DateTime.Now,
                };

                await _categoriaRepository.Adicionar(categoria);

                return Ok(categoria);
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPut]
        [Route("atualizar")]
        public async Task<ActionResult> AtualizarCategoria([FromBody] CategoriaCadastrarRequest categoria)
        {
            if (categoria == null) return BadRequest("Nenhum valor chegou na API");



            return Ok(categoriaDb);
        }
    }
}
