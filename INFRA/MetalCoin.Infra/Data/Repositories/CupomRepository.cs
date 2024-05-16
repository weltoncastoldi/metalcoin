using Metalcoin.Core.Domain;
using Metalcoin.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalCoin.Infra.Data.Repositories
{
    public class CupomRepository : Repository<Cupom>, ICuponsRepository
    {
        public CupomRepository(AppDbContext db) : base(db) { }

        public async Task<Cupom> BuscarPorNome(string codigo)
        {
            var response = await DbSet.Where(x => x.Codigo == codigo).FirstOrDefaultAsync();
            return response;
        }
    }
}
