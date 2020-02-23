using RCSS.AppServices.Dtos; 

namespace RCSS.AppServices.Interfaces.Authentication
{
    public interface IAuthenticationAppService
    {
        ModelService<UsuarioTokenAuthentication> Logar(LoginAuthentication login, string strSecretKey);
    }
}
