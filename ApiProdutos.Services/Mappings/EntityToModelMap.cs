using ApiProdutos.Data.Entities;
using ApiProdutos.Services.Models;
using AutoMapper;

namespace ApiProdutos.Services.Mappings
{
    /// <summary>
    /// Mapear transferencias de dados de Entities para Models
    /// </summary>
    public class EntityToModelMap : Profile
    {
        //método construtor
        public EntityToModelMap()
        {
            CreateMap<Categoria, CategoriasGetModel>();
            CreateMap<Produto, ProdutosGetModel>();
        }
    }
}



