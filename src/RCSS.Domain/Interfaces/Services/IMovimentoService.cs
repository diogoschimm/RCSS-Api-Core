using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Services
{
    public interface IMovimentoService : IServiceBase<Movimento>
    {
        IEnumerable<Movimento> GetByAnoMes(int ano, int mes);
        Movimento GetById(int idMovimento);
    }
}
