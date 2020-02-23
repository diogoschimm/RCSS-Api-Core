using RCSS.AppServices.ViewModels.Base;
using System;

namespace RCSS.AppServices.ViewModels
{
    public class MovimentoEstoqueViewModel : ViewModelBase
    {
        public int IdMovimentacao { get; set; }

        public int? IdProduto { get; set; }
        public virtual ProdutoViewModel Produto { get; set; }

        public string TipoMovimento { get; set; }
        public DateTime? DataMovimento { get; set; }
        public int? QtdMovimentada { get; set; }
    }
}
