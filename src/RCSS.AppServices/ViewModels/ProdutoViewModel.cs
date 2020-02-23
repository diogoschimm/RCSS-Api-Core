using RCSS.AppServices.ViewModels.Base;
using System.Collections.Generic;

namespace RCSS.AppServices.ViewModels
{
    public class ProdutoViewModel : ViewModelBase
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string ObservacaoProduto { get; set; }
        public decimal? ValorCompra { get; set; }
        public decimal? ValorVenda { get; set; }

        public ICollection<MovimentoEstoqueViewModel> MovimentosEstoque { get; set; }
    }
}
