using Metalcoin.Core.Interfaces.Repositories;
using MetalCoin.Infra.Data;
using MetalCoin.Infra.Data.Repositories;

namespace MetalCoin.Api.Configuracoes
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ResolveDependencias
            (this IServiceCollection services)
        {
            services.AddSingleton<AppDbContext>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();

            return services;
        }
    }
}
