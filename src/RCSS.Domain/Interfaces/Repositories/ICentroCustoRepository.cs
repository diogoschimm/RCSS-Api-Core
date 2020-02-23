using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Repositories
{
    public interface ICentroCustoRepository : IRepositoryBase<CentroCusto>
    {
        IEnumerable<CentroCusto> GetAll();
        CentroCusto GetById(int idCentroCusto);
    }
}
