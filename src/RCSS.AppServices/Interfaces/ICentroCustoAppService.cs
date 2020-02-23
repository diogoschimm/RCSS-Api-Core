using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces.Base;
using RCSS.AppServices.ViewModels;
using System.Collections.Generic;

namespace RCSS.AppServices.Interfaces
{
    public interface ICentroCustoAppService : IAppServiceBase<CentroCustoViewModel>
    {
        ModelTableService<CentroCustoViewModel> GetAll();
        ModelService<CentroCustoViewModel> GetById(int idCentroCusto);
        RetornoService Delete(int idCentroCusto);
    }
}
