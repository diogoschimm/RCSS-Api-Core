using RCSS.Domain.Entities.Base;
using System; 

namespace RCSS.Domain.Entities
{
    public class MovimentoEstoque : EntidadeBase
    {
        public int IdMovimentacao { get; set; }
        
        public int? IdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public string TipoMovimento { get; set; }
        public DateTime? DataMovimento { get; set; }
        public int? QtdMovimentada { get; set; }

        public override bool Validar()
        {
            return this.Valid;
        }
    }
}
