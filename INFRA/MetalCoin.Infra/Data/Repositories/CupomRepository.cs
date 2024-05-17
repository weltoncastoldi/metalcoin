using Metalcoin.Core.Domain;
using Metalcoin.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MetalCoin.Infra.Data.Repositories
{
    public class CupomRepository : Repository<Cupom>, ICuponsRepository
    {
        public CupomRepository(AppDbContext db) : base(db) { }

        public async Task<Cupom> BuscarPorNomeCupom(string codigo)
        {
            try
            {
                var response = await DbSet.Where(x => x.Codigo == codigo).SingleOrDefaultAsync();
                return response;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
