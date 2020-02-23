using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Services
{
    public interface IArquivoService : IServiceBase<Arquivo>
    {
        IEnumerable<Arquivo> GetAll();
        Arquivo GetById(int idArquivo); 
    }
}
