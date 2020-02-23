using System.Collections.Generic;

namespace RCSS.Domain.Dtos
{
    public class RetornoPadrao
    {
        public bool Sucesso { get; set; }
        public IList<string> Mensagens { get; set; }

        public RetornoPadrao()
        {
            this.Mensagens = new List<string>();
        }
    }
}
