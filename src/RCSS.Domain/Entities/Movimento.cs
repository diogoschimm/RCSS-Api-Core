using RCSS.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace RCSS.Domain.Entities
{
    public class Movimento : EntidadeBase
    {
        public int IdMovimento { get; set; }
        public DateTime DataCadastro { get; set; }

        public int IdConta { get; set; }
        public virtual Conta Conta { get; set; }

        public string TipoMovimento { get; set; }
        public string DescricaoMovimento { get; set; }
        public DateTime DataMovimento { get; set; }
        public decimal ValorMovimento { get; set; }

        public int? IdFornecedor { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }

        public int? IdCentroCusto { get; set; }
        public virtual CentroCusto CentroCusto { get; set; }

        public string Observacao { get; set; }

        public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public DateTime? DataVencimento { get; set; }
        public bool? IsPago { get; set; }

        public int? IdPessoaPagador { get; set; }
        public virtual Pessoa PessoaPagador { get; set; }

        public ICollection<ItemMovimento> ItemsMovimento { get; set; }

        public override bool Validar()
        {
            return this.Valid;
        }
    }
}
