using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Services
{
    public interface IMovimentoEstoqueService : IServiceBase<MovimentoEstoque>
    {
        IEnumerable<MovimentoEstoque> GetAll();
        MovimentoEstoque GetById(int idMovimentacao);
    }
}
