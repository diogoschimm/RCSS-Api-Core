using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Infra.Data.Contexts;
using RCSS.Infra.Data.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace RCSS.Infra.Data.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(ProjetoRcssContext context) : base(context) { }

        public IEnumerable<Pessoa> GetAll()
        {
            return this._context.Pessoa;
        }

        public Pessoa GetById(int idPessoa)
        {
            return this._context.Pessoa.FirstOrDefault(p => p.IdPessoa == idPessoa);
        }
    }
}
