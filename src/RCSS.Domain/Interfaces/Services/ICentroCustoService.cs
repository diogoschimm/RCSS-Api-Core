using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Services
{
    public interface ICentroCustoService : IServiceBase<CentroCusto>
    {
        IEnumerable<CentroCusto> GetAll();
        CentroCusto GetById(int idCentroCusto); 
    }
}
