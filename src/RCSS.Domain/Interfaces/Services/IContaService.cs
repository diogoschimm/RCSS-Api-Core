using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Services
{
    public interface IContaService : IServiceBase<Conta>
    {
        IEnumerable<Conta> GetAll();
        IEnumerable<Conta> GetContasComArquivo();

        Conta GetById(int idConta);     
    }
}
