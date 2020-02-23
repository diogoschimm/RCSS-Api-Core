using RCSS.Domain.Entities.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Entities
{
    public class Produto : EntidadeBase
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string ObservacaoProduto { get; set; }
        public decimal? ValorCompra { get; set; }
        public decimal? ValorVenda { get; set; }

        public ICollection<MovimentoEstoque> MovimentosEstoque { get; set; }

        public override bool Validar()
        {
            return this.Valid;
        }
    }
}
