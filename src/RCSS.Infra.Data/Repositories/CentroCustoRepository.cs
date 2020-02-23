using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Infra.Data.Contexts;
using RCSS.Infra.Data.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace RCSS.Infra.Data.Repositories
{
    public class CentroCustoRepository : RepositoryBase<CentroCusto>, ICentroCustoRepository
    {
        public CentroCustoRepository(ProjetoRcssContext context) : base(context) { }

        public IEnumerable<CentroCusto> GetAll()
        {
            return this._context.CentroCusto;
        }

        public CentroCusto GetById(int idCentroCusto)
        {
            return this._context.CentroCusto.FirstOrDefault(cc => cc.IdCentroCusto == idCentroCusto);
        }
    }
}
