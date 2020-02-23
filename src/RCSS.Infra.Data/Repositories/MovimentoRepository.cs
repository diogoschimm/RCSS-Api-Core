using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Infra.Data.Contexts;
using RCSS.Infra.Data.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace RCSS.Infra.Data.Repositories
{
    public class MovimentoRepository : RepositoryBase<Movimento>, IMovimentoRepository
    {
        public MovimentoRepository(ProjetoRcssContext context) : base(context) { }

        public IEnumerable<Movimento> GetByAnoMes(int ano, int mes)
        {
            return this._context.Movimento.Where(m => m.DataVencimento.Value.Year == ano && m.DataVencimento.Value.Month == mes);
        }

        public Movimento GetById(int idMovimento)
        {
            return this._context.Movimento.FirstOrDefault(m => m.IdMovimento == idMovimento);
        }
    }
}
