using RCSS.AppServices.ViewModels.Base;
using System.Collections.Generic;

namespace RCSS.AppServices.ViewModels
{
    public class FornecedorViewModel : ViewModelBase
    {
        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get; set; }

        public ICollection<MovimentoViewModel> Movimentos { get; set; }
    }
}
