using RCSS.AppServices.ViewModels.Base;
using System;

namespace RCSS.AppServices.ViewModels
{
    public class ItemMovimentoViewModel : ViewModelBase
    {
        public int IdItemMovimento { get; set; }

        public int IdMovimento { get; set; }
        public virtual MovimentoViewModel Movimento { get; set; }

        public string Historico { get; set; }

        public int IdPessoa { get; set; }
        public virtual PessoaViewModel Pessoa { get; set; }

        public decimal Valor { get; set; }
        public DateTime? Data { get; set; }

        public int? IdCentroCusto { get; set; }
        public virtual CentroCustoViewModel CentroCusto { get; set; }

        public string ChaveLancamento { get; set; }
        public int? NumeroParcela { get; set; }
        public int? TotalParcela { get; set; }

        public int? IdPessoaPagador { get; set; }
        public virtual PessoaViewModel PessoaPagador { get; set; }
    }
}
