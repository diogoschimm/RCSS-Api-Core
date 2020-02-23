using RCSS.Domain.Entities;
using RCSS.Infra.Identity.Dtos;

namespace RCSS.Infra.Identity.Interfaces.Jwt
{
    public interface ITokenService
    {
        TokenAuthentication GerarToken(Usuario usuario, string strSecretKey);
    }
}
