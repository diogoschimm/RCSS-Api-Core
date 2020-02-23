using RCSS.Domain.Entities.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Entities
{
    public class Pessoa : EntidadeBase
    {
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }

        public ICollection<Movimento> Movimentos { get; set; }
        public ICollection<Movimento> MovimentosComoPagador { get; set; }

        public ICollection<ItemMovimento> ItemsMovimento { get; set; }
        public ICollection<ItemMovimento> ItemsMovimentoComoPagador { get; set; }

        public override bool Validar()
        {
            return this.Valid;
        }
    }
}
