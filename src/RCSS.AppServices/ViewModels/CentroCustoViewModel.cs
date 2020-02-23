using RCSS.AppServices.ViewModels.Base;
using System.Collections.Generic;

namespace RCSS.AppServices.ViewModels
{
    public class CentroCustoViewModel : ViewModelBase
    {
        public int IdCentroCusto { get; set; }
        public string NomeCentroCusto { get; set; }

        public ICollection<MovimentoViewModel> Movimentos { get; set; }
        public ICollection<ItemMovimentoViewModel> ItensMovimento { get; set; }
    }
}
