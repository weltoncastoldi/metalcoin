using MetalCoin.Web.Spa.Core.Models;

namespace MetalCoin.Web.Spa.Core.Endpoint
{
    public interface ICategoriaEndpoint 
    { 
        Task Cadastrar(CategoriaRequest request);
        Task Atualizar(CategoriaRequest request);
        Task Remover(Guid Id);
        Task Ativar (Guid Id);
        Task Desativar(Guid Id);
        Task<CategoriaResponse> ObterUm(Guid Id);
        Task<List<CategoriaResponse>> ObterTodos();
    }

    public class CategoriaEndpoint : ICategoriaEndpoint
    {
        public Task Ativar(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(CategoriaRequest request)
        {
            throw new NotImplementedException();
        }

        public Task Cadastrar(CategoriaRequest request)
        {
            throw new NotImplementedException();
        }

        public Task Desativar(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoriaResponse>> ObterTodos()
        {
            var response = new List<CategoriaResponse>
            {
                new CategoriaResponse
                {
                    Id = 1,
                    Nome = "Eletrônicos",
                    Status = true,
                    Alterado = DateTime.UtcNow.AddDays(-5),
                    Criado = DateTime.UtcNow.AddDays(-30),
                    QuantidadeProdutosVinculados = 150
                },
                new CategoriaResponse
                {
                    Id = 2,
                    Nome = "Roupas",
                    Status = true,
                    Alterado = DateTime.UtcNow.AddDays(-10),
                    Criado = DateTime.UtcNow.AddDays(-60),
                    QuantidadeProdutosVinculados = 300
                },
                new CategoriaResponse
                {
                    Id = 3,
                    Nome = "Esporte",
                    Status = true,
                    Alterado = DateTime.UtcNow.AddDays(-5),
                    Criado = DateTime.UtcNow.AddDays(-30),
                    QuantidadeProdutosVinculados = 20
                },
                new CategoriaResponse {
                    Id = 4,
                    Nome = "Celular",
                    Status = false,
                    Alterado = DateTime.UtcNow.AddDays(0),
                    Criado = DateTime.UtcNow.AddDays(-2),
                    QuantidadeProdutosVinculados = 50
                },
            };

            return Task.FromResult(response);
        }

        public Task<CategoriaResponse> ObterUm(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
