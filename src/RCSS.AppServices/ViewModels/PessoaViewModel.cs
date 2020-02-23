using RCSS.AppServices.ViewModels.Base;
using System.Collections.Generic;

namespace RCSS.AppServices.ViewModels
{
    public class PessoaViewModel : ViewModelBase
    {
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }

        public ICollection<MovimentoViewModel> Movimentos { get; set; }
        public ICollection<MovimentoViewModel> MovimentosComoPagador { get; set; }

        public ICollection<ItemMovimentoViewModel> ItemsMovimento { get; set; }
        public ICollection<ItemMovimentoViewModel> ItemsMovimentoComoPagador { get; set; }
    }
}
