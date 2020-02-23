using AutoMapper;
using RCSS.AppServices.ViewModels;
using RCSS.Domain.Entities;

namespace RCSS.AppServices.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Arquivo, ArquivoViewModel>();
            CreateMap<CentroCusto, CentroCustoViewModel>();
            CreateMap<Conta, ContaViewModel>();
            CreateMap<Fornecedor, FornecedorViewModel>();
            CreateMap<ItemMovimento, ItemMovimentoViewModel>();
            CreateMap<Movimento, MovimentoViewModel>();
            CreateMap<MovimentoEstoque, MovimentoEstoqueViewModel>();
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}
