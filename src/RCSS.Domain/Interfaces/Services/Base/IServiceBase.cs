namespace RCSS.Domain.Interfaces.Services.Base
{
    public interface IServiceBase<T> where T: class
    {
        T Save(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
