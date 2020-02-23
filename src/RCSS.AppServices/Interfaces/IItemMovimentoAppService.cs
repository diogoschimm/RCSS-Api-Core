using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces.Base;
using RCSS.AppServices.ViewModels;

namespace RCSS.AppServices.Interfaces
{
    public interface IItemMovimentoAppService : IAppServiceBase<ItemMovimentoViewModel>
    {
        ModelTableService<ItemMovimentoViewModel> GetByMovimento(int idMovimento);
        ModelService<ItemMovimentoViewModel> GetById(int idItemMovimento);
        RetornoService Delete(int idItemMovimento);
    }
}
