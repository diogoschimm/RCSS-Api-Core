using RCSS.Domain.Entities.Base;
using System; 

namespace RCSS.Domain.Entities
{
    public class ItemMovimento : EntidadeBase
    {
        public int IdItemMovimento { get; set; }

        public int IdMovimento { get; set; }
        public virtual Movimento Movimento { get; set; }

        public string Historico { get; set; }

        public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public decimal Valor { get; set; }
        public DateTime? Data { get; set; }

        public int? IdCentroCusto { get; set; }
        public virtual CentroCusto CentroCusto { get; set; }

        public string ChaveLancamento { get; set; }
        public int? NumeroParcela { get; set; }
        public int? TotalParcela { get; set; }

        public int? IdPessoaPagador { get; set; }
        public virtual Pessoa PessoaPagador { get; set; }

        public override bool Validar()
        {
            return this.Valid;
        }
    }
}
