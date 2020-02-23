using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces.Base;
using RCSS.AppServices.ViewModels;

namespace RCSS.AppServices.Interfaces
{
    public interface IFornecedorAppService : IAppServiceBase<FornecedorViewModel>
    {
        ModelTableService<FornecedorViewModel> GetAll();
        ModelService<FornecedorViewModel> GetById(int idFornecedor);
        RetornoService Delete(int idFornecedor);
    }
}
