using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces.Base;
using RCSS.AppServices.ViewModels;

namespace RCSS.AppServices.Interfaces
{
    public interface IArquivoAppService : IAppServiceBase<ArquivoViewModel>
    {
        ModelTableService<ArquivoViewModel> GetAll();
        ModelService<ArquivoViewModel> GetById(int idArquivo);
        RetornoService Delete(int idArquivo);
    }
}
