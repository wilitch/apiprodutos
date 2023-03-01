using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiProdutos.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProdutos.Data.Mappings
{
    /// <summary>
    /// Classe de mapeamento para a entidade Produto
    /// </summary>
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //Nome da tabela no banco de dados
            builder.ToTable("PRODUTO");

            //definir a chave primária da tabela
            builder.HasKey(p => p.IdProduto);

            //mapeamento dos campos
            builder.Property(p => p.IdProduto)
                .HasColumnName("IDPRODUTO");

            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnName("DESCRICAO")
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasColumnName("PRECO")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.Quantidade)
                .HasColumnName("QUANTIDADE")
                .IsRequired();

            builder.Property(p => p.DataHoraCadastro)
                .HasColumnName("DATAHORACADASTRO")
                .IsRequired();

            builder.Property(p => p.IdCategoria)
                .HasColumnName("IDCATEGORIA")
                .IsRequired();

            //mapeamento do relacionamento 1 para muitos
            //e da foreign key (chave estrangeira)
            builder.HasOne(p => p.Categoria) //Produto tem uma Categoria
                .WithMany(c => c.Produtos) //Categoria tem muitos Produtos
                .HasForeignKey(p => p.IdCategoria);
        }
    }
}
