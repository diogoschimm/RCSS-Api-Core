using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Infra.Data.Contexts;
using RCSS.Infra.Data.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace RCSS.Infra.Data.Repositories
{
    public class ContaRepository : RepositoryBase<Conta>, IContaRepository
    {
        public ContaRepository(ProjetoRcssContext context) : base(context) { }

        public IEnumerable<Conta> GetAll()
        {
            return this._context.Conta;
        }

        public IEnumerable<Conta> GetContasComArquivo()
        {
            return this._context.Conta.Where(c => c.Arquivos.Count() > 0);
        }

        public Conta GetById(int idConta)
        {
            return this._context.Conta.FirstOrDefault(c => c.IdConta == idConta);
        }
    }
}
