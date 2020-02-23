using Microsoft.Extensions.DependencyInjection;
using RCSS.AppServices.AutoMapper;
using RCSS.AppServices.Interfaces;
using RCSS.AppServices.Interfaces.Authentication;
using RCSS.AppServices.Services;
using RCSS.AppServices.Services.Authentication;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Domain.Interfaces.Services;
using RCSS.Domain.Interfaces.UnitOfWork;
using RCSS.Domain.Services;
using RCSS.Infra.Data.Contexts;
using RCSS.Infra.Data.Repositories;
using RCSS.Infra.Data.UnitOfWork;
using RCSS.Infra.Identity.Interfaces.Jwt;
using RCSS.Infra.Identity.Services;

namespace RCSS.Infra.CrossCutting.IoC
{
    public class NativeInjectorMapping
    {
        public static void RegisterServices(IServiceCollection services)
        {
            RegisterServicesApplication(services);
            RegisterServicesDomain(services);
            RegisterServicesRepository(services);
            RegisterServicesIdentity(services);

            services.AddSingleton(AutoMapperConfiguration.RegisterMappings().CreateMapper());
            services.AddScoped<ProjetoRcssContext>();
        }

        private static void RegisterServicesApplication(IServiceCollection services)
        {
            services.AddScoped<IArquivoAppService, ArquivoAppService>();
            services.AddScoped<ICentroCustoAppService, CentroCustoAppService>();
            services.AddScoped<IContaAppService, ContaAppService>();
            services.AddScoped<IFornecedorAppService, FornecedorAppService>();
            services.AddScoped<IItemMovimentoAppService, ItemMovimentoAppService>();
            services.AddScoped<IMovimentoEstoqueAppService, MovimentoEstoqueAppService>();
            services.AddScoped<IMovimentoAppService, MovimentoAppService>();
            services.AddScoped<IPessoaAppService, PessoaAppService>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IAuthenticationAppService, AuthenticationAppService>();
        }

        private static void RegisterServicesDomain(IServiceCollection services)
        {
            services.AddScoped<IArquivoService, ArquivoService>();
            services.AddScoped<ICentroCustoService, CentroCustoService>();
            services.AddScoped<IContaService, ContaService>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IItemMovimentoService, ItemMovimentoService>();
            services.AddScoped<IMovimentoEstoqueService, MovimentoEstoqueService>();
            services.AddScoped<IMovimentoService, MovimentoService>();
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
        }

        private static void RegisterServicesRepository(IServiceCollection services)
        {
            services.AddScoped<IArquivoRepository, ArquivoRepository>();
            services.AddScoped<ICentroCustoRepository, CentroCustoRepository>();
            services.AddScoped<IContaRepository, ContaRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IItemMovimentoRepository, ItemMovimentoRepository>();
            services.AddScoped<IMovimentoEstoqueRepository, MovimentoEstoqueRepository>();
            services.AddScoped<IMovimentoRepository, MovimentoRepository>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        private static void RegisterServicesIdentity(IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}
