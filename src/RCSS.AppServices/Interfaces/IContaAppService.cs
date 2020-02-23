using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces.Base;
using RCSS.AppServices.ViewModels;

namespace RCSS.AppServices.Interfaces
{
    public interface IContaAppService : IAppServiceBase<ContaViewModel>
    {
        ModelTableService<ContaViewModel> GetAll();
        ModelTableService<ContaViewModel> GetContasComArquivo();

        ModelService<ContaViewModel> GetById(int idConta);
        RetornoService Delete(int idConta);
    }
}
