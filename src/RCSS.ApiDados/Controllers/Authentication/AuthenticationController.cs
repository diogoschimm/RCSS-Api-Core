using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RCSS.ApiDados.Controllers.Base;
using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces.Authentication;
using RCSS.Infra.Identity.Dtos;

namespace RCSS.ApiDados.Controllers.Authentication
{
    [Route("api/[controller]")]
    public class AuthenticationController : ApiBaseController<TokenAuthentication>
    {
        private readonly IConfiguration _configuration;
        private readonly IAuthenticationAppService _authenticationAppService;

        public AuthenticationController(ILogger<TokenAuthentication> logger, IConfiguration configuration, IAuthenticationAppService authenticationAppService) : base(logger)
        {
            this._configuration = configuration;
            this._authenticationAppService = authenticationAppService;
        }

        [HttpPost()]
        public ModelService<UsuarioTokenAuthentication> Post([FromBody]LoginAuthentication value)
        {
            return TryExecute(() =>
            {
                var secretKey = _configuration.GetSection("Jwt").GetValue<string>("SecretKey");
                return this._authenticationAppService.Logar(value, secretKey);
            });
        }
    }
}
