using RCSS.AppServices.ViewModels.Base;
using System;

namespace RCSS.AppServices.ViewModels
{
    public class ArquivoViewModel : ViewModelBase
    {
        public int IdArquivo { get; set; }

        public int IdConta { get; set; }
        public virtual ContaViewModel Conta { get; set; }

        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Historico { get; set; }
        public string NomeArquivo { get; set; }
    }
}
