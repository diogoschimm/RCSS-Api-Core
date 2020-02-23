using System.Collections.Generic;

namespace RCSS.AppServices.Dtos
{
    public class RetornoService
    { 
        public bool Sucesso { get; set; }
        public IList<string> Mensagens { get; set; }

        public RetornoService()
        {
            this.Mensagens = new List<string>();
        }
    }
}
