using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Infra.Data.Contexts;
using RCSS.Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RCSS.Infra.Data.Repositories
{
    public class ItemMovimentoRepository : RepositoryBase<ItemMovimento>, IItemMovimentoRepository
    {
        public ItemMovimentoRepository(ProjetoRcssContext context) : base(context) { }

        public IEnumerable<ItemMovimento> GetByMovimento(int idMovimento)
        {
            return this._context.ItemMovimento.Where(im => im.IdMovimento == idMovimento);
        }

        public ItemMovimento GetById(int idItemMovimento)
        {
            return this._context.ItemMovimento.FirstOrDefault(im => im.IdItemMovimento == idItemMovimento);
        }
    }
}
