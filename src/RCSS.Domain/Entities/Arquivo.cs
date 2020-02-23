using RCSS.Domain.Entities.Base;
using System;

namespace RCSS.Domain.Entities
{
    public class Arquivo : EntidadeBase
    {
        public int IdArquivo { get; set; }
        
        public int IdConta { get; set; }
        public virtual Conta Conta { get; set; }

        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Historico { get; set; }
        public string NomeArquivo { get; set; }

        public override bool Validar()
        {
            return this.Valid;
        }
    }
}
