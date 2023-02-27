using System.ComponentModel.DataAnnotations;

namespace ApiProdutos.Services.Models
{
    /// <summary>
    /// Modelo de dados para consulta de produtos
    /// </summary>
    public class ProdutosGetModel
    {
        public Guid? IdProduto { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public DateTime? DataHoraCadastro { get; set; }
        /// <summary>
        /// Dados da categoria do produto
        /// </summary>
        public CategoriasGetModel? Categoria { get; set; }
    }
}
