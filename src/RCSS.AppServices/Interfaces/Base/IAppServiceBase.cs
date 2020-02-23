using RCSS.AppServices.Dtos;

namespace RCSS.AppServices.Interfaces.Base
{
    public interface IAppServiceBase<T> where T : class 
    {
        ModelService<T> Save(T model);
        ModelService<T> Update(T model);
    }
}
