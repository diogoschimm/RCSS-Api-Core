using RCSS.AppServices.ViewModels.Base;
using System.Collections.Generic;

namespace RCSS.AppServices.ViewModels
{
    public class ContaViewModel : ViewModelBase
    {
        public int IdConta { get; set; }
        public string NomeConta { get; set; }

        public ICollection<ArquivoViewModel> Arquivos { get; set; }
        public ICollection<MovimentoViewModel> Movimentos { get; set; }
    }
}
