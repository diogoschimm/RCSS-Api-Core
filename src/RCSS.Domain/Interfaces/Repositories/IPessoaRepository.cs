using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RCSS.Domain.Interfaces.Repositories
{
    public interface IPessoaRepository : IRepositoryBase<Pessoa>
    {
        IEnumerable<Pessoa> GetAll();
        Pessoa GetById(int idPessoa);
    }
}
