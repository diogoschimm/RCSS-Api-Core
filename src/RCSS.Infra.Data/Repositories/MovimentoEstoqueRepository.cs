using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Infra.Data.Contexts;
using RCSS.Infra.Data.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace RCSS.Infra.Data.Repositories
{
    public class MovimentoEstoqueRepository : RepositoryBase<MovimentoEstoque>, IMovimentoEstoqueRepository
    {
        public MovimentoEstoqueRepository(ProjetoRcssContext context) : base(context) { }

        public IEnumerable<MovimentoEstoque> GetAll()
        {
            return this._context.MovimentoEstoque;
        }

        public MovimentoEstoque GetById(int idMovimentacao)
        {
            return this._context.MovimentoEstoque.FirstOrDefault(me => me.IdMovimentacao == idMovimentacao);
        }
    }
}
