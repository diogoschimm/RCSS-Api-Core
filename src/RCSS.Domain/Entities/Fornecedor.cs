using RCSS.Domain.Entities.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Entities
{
    public class Fornecedor : EntidadeBase
    {
        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get; set; }

        public ICollection<Movimento> Movimentos { get; set; }

        public override bool Validar()
        {
            return this.Valid;
        }
    }
}
