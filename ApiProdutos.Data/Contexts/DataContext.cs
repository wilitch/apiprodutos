using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiProdutos.Data.Entities;
using ApiProdutos.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ApiProdutos.Data.Contexts
{
    /// <summary>
    /// Classe para conexão com o banco de dados através do EF
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Método para mapear a string de conexão do banco de dados no EF
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD_ApiProdutos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        /// <summary>
        /// Método para adicionarmos as classes de mapeamento do projeto
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }

        /// <summary>
        /// Propriedade para fornecer os métodos de CRUD para Categoria
        /// </summary>
        public DbSet<Categoria> Categorias { get; set; }

        /// <summary>
        /// Propriedade para fornecer os métodos de CRUD para Produto
        /// </summary>
        public DbSet<Produto> Produtos { get; set; }

    }
}
;