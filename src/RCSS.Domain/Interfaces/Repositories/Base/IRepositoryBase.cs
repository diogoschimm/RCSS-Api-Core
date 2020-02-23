namespace RCSS.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        T Save(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
