using RCSS.Domain.Entities.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Entities
{
    public class CentroCusto : EntidadeBase
    {
        public int IdCentroCusto { get; set; }
        public string NomeCentroCusto { get; set; }

        public ICollection<Movimento> Movimentos { get; set; }
        public ICollection<ItemMovimento> ItensMovimento { get; set; }

        public override bool Validar()
        {
            return this.Valid;
        }
    }
}
