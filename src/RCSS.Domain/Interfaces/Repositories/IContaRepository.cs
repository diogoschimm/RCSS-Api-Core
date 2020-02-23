using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Repositories
{
    public interface IContaRepository : IRepositoryBase<Conta>
    {
        IEnumerable<Conta> GetAll();
        IEnumerable<Conta> GetContasComArquivo();

        Conta GetById(int idConta);
    }
}
