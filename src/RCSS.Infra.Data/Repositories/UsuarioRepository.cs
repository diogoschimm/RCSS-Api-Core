using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Infra.Data.Contexts;
using RCSS.Infra.Data.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace RCSS.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ProjetoRcssContext context) : base(context) { }

        public IEnumerable<Usuario> GetAll()
        {
            return _context.Usuario;
        }

        public Usuario GetById(int usuarioId)
        {
            return _context.Usuario.FirstOrDefault(u => u.UsuarioId == usuarioId);
        }

        public Usuario GetByLoginSenha(string login, string senha)
        {
            return this._context.Usuario.FirstOrDefault(u => u.Login == login && u.Senha == senha);
        }
    }
}
