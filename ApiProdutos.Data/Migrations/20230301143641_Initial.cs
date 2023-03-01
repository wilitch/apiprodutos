﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiProdutos.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIA",
                columns: table => new
                {
                    IDCATEGORIA = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DESCRICAO = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIA", x => x.IDCATEGORIA);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTO",
                columns: table => new
                {
                    IDPRODUTO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DESCRICAO = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PRECO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QUANTIDADE = table.Column<int>(type: "int", nullable: false),
                    DATAHORACADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDCATEGORIA = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTO", x => x.IDPRODUTO);
                    table.ForeignKey(
                        name: "FK_PRODUTO_CATEGORIA_IDCATEGORIA",
                        column: x => x.IDCATEGORIA,
                        principalTable: "CATEGORIA",
                        principalColumn: "IDCATEGORIA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_IDCATEGORIA",
                table: "PRODUTO",
                column: "IDCATEGORIA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUTO");

            migrationBuilder.DropTable(
                name: "CATEGORIA");
        }
    }
}
