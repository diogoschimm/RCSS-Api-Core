using Microsoft.EntityFrameworkCore;
using RCSS.Domain.Interfaces.Repositories.Base;
using RCSS.Infra.Data.Contexts;

namespace RCSS.Infra.Data.Repositories.Base
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly ProjetoRcssContext _context;
        protected readonly DbSet<T> DbSet;

        public RepositoryBase(ProjetoRcssContext context)
        {
            this._context = context;
            this.DbSet = this._context.Set<T>();
        }

        public T Save(T entity)
        {
            this.DbSet.Add(entity);
            return entity;
        }

        public T Update(T entity)
        {
            this.DbSet.Update(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            this.DbSet.Remove(entity);
        }
    }
}
