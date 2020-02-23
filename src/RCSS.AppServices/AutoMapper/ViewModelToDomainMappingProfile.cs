using AutoMapper;
using RCSS.AppServices.ViewModels;
using RCSS.Domain.Entities;

namespace RCSS.AppServices.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ArquivoViewModel, Arquivo>();
            CreateMap<CentroCustoViewModel, CentroCusto>();
            CreateMap<ContaViewModel, Conta>();
            CreateMap<FornecedorViewModel, Fornecedor>();
            CreateMap<ItemMovimentoViewModel, ItemMovimento>();
            CreateMap<MovimentoViewModel, Movimento>();
            CreateMap<MovimentoEstoqueViewModel, MovimentoEstoque>();
            CreateMap<PessoaViewModel, Pessoa>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
