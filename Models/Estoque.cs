using System;
using System.Collections.Generic;

namespace Estoque.Models
{
    public partial class Estoquer
    {
        public int Id { get; set; }
        public int CodigoProduto { get; set; }
        public int? Qtde { get; set; }
        public decimal? ValorUnitario { get; set; }

        public virtual Produto CodigoProdutoNavigation { get; set; } = null!;
    }
}
