using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Repositories
{
    public interface IArquivoRepository : IRepositoryBase<Arquivo>
    {
        IEnumerable<Arquivo> GetAll();
        Arquivo GetById(int idArquivo);
    }
}
