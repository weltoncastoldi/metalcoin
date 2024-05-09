using Metalcoin.Core.Dtos;
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

    }
}
