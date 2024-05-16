using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Interfaces.Services
{
    public interface ICupomServices
    {
        Task<CuponsResponse> CadastrarCupons(CadastrarCupunsRequest cupom);
        Task<bool> DeletarCupons(Guid id);
    }
}
