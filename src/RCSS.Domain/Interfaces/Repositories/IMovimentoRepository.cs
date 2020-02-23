using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Repositories
{
    public interface IMovimentoRepository : IRepositoryBase<Movimento>
    {
        IEnumerable<Movimento> GetByAnoMes(int ano, int mes);
        Movimento GetById(int idMovimento);
    }
}
