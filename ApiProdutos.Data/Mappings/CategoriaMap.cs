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
    /// Classe de mapeamento para a entidade Categoria
    /// </summary>
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            //Nome da tabela no banco de dados
            builder.ToTable("CATEGORIA");

            //definir a chave primária da tabela
            builder.HasKey(c => c.IdCategoria);

            //mapeamento dos campos
            builder.Property(c => c.IdCategoria)
                .HasColumnName("IDCATEGORIA");

            builder.Property(c => c.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Descricao)
                .HasColumnName("DESCRICAO")
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
