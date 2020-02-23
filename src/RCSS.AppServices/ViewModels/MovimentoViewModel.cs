using RCSS.AppServices.ViewModels.Base;
using System;
using System.Collections.Generic;

namespace RCSS.AppServices.ViewModels
{
    public class MovimentoViewModel : ViewModelBase
    {
        public int IdMovimento { get; set; }
        public DateTime DataCadastro { get; set; }

        public int IdConta { get; set; }
        public virtual ContaViewModel Conta { get; set; }

        public string TipoMovimento { get; set; }
        public string DescricaoMovimento { get; set; }
        public DateTime DataMovimento { get; set; }
        public decimal ValorMovimento { get; set; }

        public int? IdFornecedor { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }

        public int? IdCentroCusto { get; set; }
        public virtual CentroCustoViewModel CentroCusto { get; set; }

        public string Observacao { get; set; }

        public int IdPessoa { get; set; }
        public virtual PessoaViewModel Pessoa { get; set; }

        public DateTime? DataVencimento { get; set; }
        public bool? IsPago { get; set; }

        public int? IdPessoaPagador { get; set; }
        public virtual PessoaViewModel PessoaPagador { get; set; }

        public ICollection<ItemMovimentoViewModel> ItemsMovimento { get; set; }
    }
}
