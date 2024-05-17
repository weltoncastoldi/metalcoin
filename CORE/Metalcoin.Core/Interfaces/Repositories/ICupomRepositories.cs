﻿using Metalcoin.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Interfaces.Repositories
{
    public interface ICupomRepository : IRepository<Cupom>
    {
        Task<Cupom> BuscarPorNome(int codigoCupom);
        Task<Task<bool>> UpdateStatusAsync(Guid id, int v);
    }
}
