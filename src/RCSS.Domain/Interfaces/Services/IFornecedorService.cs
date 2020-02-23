﻿using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Services
{
    public interface IFornecedorService : IServiceBase<Fornecedor>
    {
        IEnumerable<Fornecedor> GetAll();
        Fornecedor GetById(int idFornecedor);
    }
}
