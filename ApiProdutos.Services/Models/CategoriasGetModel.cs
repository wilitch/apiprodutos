namespace ApiProdutos.Services.Models
{
    /// <summary>
    /// Modelo de dados para consulta de categorias
    /// </summary>
    public class CategoriasGetModel
    {
        public Guid? IdCategoria { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

    }
}
