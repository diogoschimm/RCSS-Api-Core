using RCSS.Domain.Dtos;

namespace RCSS.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        RetornoPadrao Commit();
    }
}
