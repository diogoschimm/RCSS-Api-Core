using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Repositories
{
    public interface IItemMovimentoRepository : IRepositoryBase<ItemMovimento>
    {
        IEnumerable<ItemMovimento> GetByMovimento(int idMovimento); 
        ItemMovimento GetById(int idItemMovimento);
    }
}
