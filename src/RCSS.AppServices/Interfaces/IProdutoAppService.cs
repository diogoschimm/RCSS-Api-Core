using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces.Base;
using RCSS.AppServices.ViewModels;

namespace RCSS.AppServices.Interfaces
{
    public interface IProdutoAppService : IAppServiceBase<ProdutoViewModel>
    {
        ModelTableService<ProdutoViewModel> GetAll();
        ModelService<ProdutoViewModel> GetById(int idProduto);
        RetornoService Delete(int idProduto);
    }
}
