using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace RCSS.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this._usuarioRepository = usuarioRepository;
        }

        public IEnumerable<Usuario> GetAll()
        {
            return this._usuarioRepository.GetAll();
        }

        public Usuario GetById(int usuarioId)
        {
            return this._usuarioRepository.GetById(usuarioId);
        }

        public Usuario GetByLoginSenha(string login, string senha)
        {
            return this._usuarioRepository.GetByLoginSenha(login, senha);
        }

        public Usuario Save(Usuario entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._usuarioRepository.Save(entity);

            return entity;
        }

        public Usuario Update(Usuario entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._usuarioRepository.Update(entity);

            return entity;
        }

        public void Delete(Usuario entity)
        {
            this._usuarioRepository.Delete(entity);
        }
    }
}
