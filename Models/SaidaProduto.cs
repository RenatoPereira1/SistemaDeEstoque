using System;
using System.Collections.Generic;

namespace Estoque.Models
{
    public partial class SaidaProduto
    {
        public int Id { get; set; }
        public int CodigoProduto { get; set; }
        public int? Qtde { get; set; }
        public DateOnly? DataSaida { get; set; }
        public decimal? ValorUnitario { get; set; }

        public virtual Produto CodigoProdutoNavigation { get; set; } = null!;
    }
}
