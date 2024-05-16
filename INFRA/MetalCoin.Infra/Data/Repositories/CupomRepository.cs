using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Response;
using Metalcoin.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MetalCoin.Infra.Data.Repositories
{
    public class CupomRepository : Repository<Cupom>, ICupomRespository
    {
        private readonly ICupomRespository _cupomRespository;

        public CupomRepository(AppDbContext appDbContext) : base(appDbContext) { }

        public async Task<List<Cupom>> BuscarTodosDisponiveis()
        {
            var listaDeCupons = await DbSet.Where(c => c.QuantidadeLiberado > c.QuantidadeUsado && c.Status == "ativo").ToListAsync();
            
            return listaDeCupons ;
        }

        public  async Task<List<Cupom>> BuscarTodosIndisponiveis()
        {
            var listaDeCupons = await DbSet.Where(c => c.QuantidadeLiberado <= c.QuantidadeUsado && c.Status != "ativo").ToListAsync();

            return listaDeCupons;
        }
    }
}

