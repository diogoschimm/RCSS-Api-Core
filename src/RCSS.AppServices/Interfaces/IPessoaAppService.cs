using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces.Base;
using RCSS.AppServices.ViewModels;

namespace RCSS.AppServices.Interfaces
{
    public interface IPessoaAppService : IAppServiceBase<PessoaViewModel>
    {
        ModelTableService<PessoaViewModel> GetAll();
        ModelService<PessoaViewModel> GetById(int idPessoa);
        RetornoService Delete(int idPessoa);
    }
}
