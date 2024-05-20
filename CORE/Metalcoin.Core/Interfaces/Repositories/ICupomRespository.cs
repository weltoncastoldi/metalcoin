using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Interfaces.Repositories
{
    public interface ICupomRespository : IRepository<Cupom>
    {

        Task<List<Cupom>>BuscarTodosDisponiveis();
        Task<List<Cupom>> BuscarTodosIndisponiveis();
        Task<Cupom> BuscarPorCodigo(string codigo);

    }
}
