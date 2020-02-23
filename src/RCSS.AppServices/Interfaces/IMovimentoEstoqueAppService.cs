using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces.Base;
using RCSS.AppServices.ViewModels;

namespace RCSS.AppServices.Interfaces
{
    public interface IMovimentoEstoqueAppService : IAppServiceBase<MovimentoEstoqueViewModel>
    {
        ModelTableService<MovimentoEstoqueViewModel> GetAll();
        ModelService<MovimentoEstoqueViewModel> GetById(int idMovimentacao);
        RetornoService Delete(int idMovimentacao);
    }
}
