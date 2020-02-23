using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Infra.Data.Contexts;
using RCSS.Infra.Data.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace RCSS.Infra.Data.Repositories
{
    public class ArquivoRepository : RepositoryBase<Arquivo>, IArquivoRepository
    {
        public ArquivoRepository(ProjetoRcssContext context) : base(context) { }

        public IEnumerable<Arquivo> GetAll()
        {
            return this._context.Arquivo;
        }

        public Arquivo GetById(int idArquivo)
        {
            return this._context.Arquivo.FirstOrDefault(a => a.IdArquivo == idArquivo);
        }
    }
}
