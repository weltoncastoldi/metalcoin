using Metalcoin.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Interfaces.Repositories
{
    public interface ICuponsRepository : IRepository<Cupon>
    {
        Task<Cupon> BuscarPorNome(int codigo);
    }
}
