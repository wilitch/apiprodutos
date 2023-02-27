using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProdutos.Data.Entities
{
    /// <summary>
    /// Classe de entidade para Categoria
    /// </summary>
    public class Categoria
    {
        private Guid? _idCategoria;
        private string? _nome;
        private string? _descricao;

        public Guid? IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Descricao { get => _descricao; set => _descricao = value; }
    }
}
