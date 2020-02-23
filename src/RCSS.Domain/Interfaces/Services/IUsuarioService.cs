using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        IEnumerable<Usuario> GetAll();
        Usuario GetById(int usuarioId);

        Usuario GetByLoginSenha(string login, string senha);
    }
}
