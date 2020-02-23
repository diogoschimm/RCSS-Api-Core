using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Services
{
    public interface IItemMovimentoService : IServiceBase<ItemMovimento>
    {
        IEnumerable<ItemMovimento> GetByMovimento(int idMovimento);
        ItemMovimento GetById(int idItemMovimento);
    }
}
