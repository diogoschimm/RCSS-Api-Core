using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces.Authentication;
using RCSS.Domain.Interfaces.Services;
using RCSS.Infra.Identity.Interfaces.Jwt;
using System;

namespace RCSS.AppServices.Services.Authentication
{
    public class AuthenticationAppService : IAuthenticationAppService
    {
        private readonly IUsuarioService _usuarioService;
        private readonly ITokenService _tokenService;

        public AuthenticationAppService(IUsuarioService usuarioService, ITokenService tokenService)
        {
            this._usuarioService = usuarioService;
            this._tokenService = tokenService;
        }

        public ModelService<UsuarioTokenAuthentication> Logar(LoginAuthentication login, string strSecretKey)
        {
            var usuario = _usuarioService.GetByLoginSenha(login.UserName, login.Password);
            if (usuario == null)
                throw new Exception("Username ou Password incorretos");

            var model = new UsuarioTokenAuthentication
            {
                UsuarioId = usuario.UsuarioId,
                NomeUsuario = usuario.NomeUsuario,
                LoginUsuario = usuario.Login,
                Token = this._tokenService.GerarToken(usuario, strSecretKey)
            };

            return new ModelService<UsuarioTokenAuthentication>
            {
                Sucesso = true,
                Mensagens = { "Login realizado com sucesso" },
                Model = model
            };
        }
    }
}
