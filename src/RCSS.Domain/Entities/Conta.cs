using RCSS.Domain.Entities.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Entities
{
    public class Conta : EntidadeBase
    {
        public int IdConta { get; set; }
        public string NomeConta { get; set; }

        public ICollection<Arquivo> Arquivos { get; set; }
        public ICollection<Movimento> Movimentos { get; set; }

        public override bool Validar()
        {
            return this.Valid;
        }
    }
}
