using Metalcoin.Core.Dtos.Categorias;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;

namespace MetalCoin.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository repository) 
        {
            _categoriaRepository = repository;
        }

        public async Task<CategoriaResponse> AtualizarCategoria(CategoriaAtualizarRequest categoria)
        {
            var categoriaDb = await _categoriaRepository.ObterPorId(categoria.Id);
                       
            categoriaDb.Status = categoria.Status;
            categoriaDb.Nome = categoria.Nome.ToUpper();
            categoriaDb.DataAlteracao = DateTime.Now;

            await _categoriaRepository.Atualizar(categoriaDb);

            var response = new CategoriaResponse
            {
                Id = categoriaDb.Id,
                Nome = categoriaDb.Nome,
                Status = categoriaDb.Status,
                DataAlteracao = categoriaDb.DataAlteracao,
                DataCadastro = categoriaDb.DataCadastro
            };

            return response;
        }

        public Task<CategoriaResponse> CadastrarCategoria(CategoriaCadastrarRequest categoria)
        {
            throw new NotImplementedException();
        }

        public Task DeletarCategoria(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
