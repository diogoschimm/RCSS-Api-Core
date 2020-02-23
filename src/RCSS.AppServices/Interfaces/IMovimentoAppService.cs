using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces.Base;
using RCSS.AppServices.ViewModels;

namespace RCSS.AppServices.Interfaces
{
    public interface IMovimentoAppService : IAppServiceBase<MovimentoViewModel>
    {
        ModelTableService<MovimentoViewModel> GetByAnoMes(int ano, int mes);
        ModelService<MovimentoViewModel> GetById(int idMovimento);
        RetornoService Delete(int idMovimento);
    }
}
