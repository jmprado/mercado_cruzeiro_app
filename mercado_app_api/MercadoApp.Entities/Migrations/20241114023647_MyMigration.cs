using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercadoApp.Entities.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<int>(type: "INTEGER", nullable: false),
                    Logradouro = table.Column<string>(type: "TEXT", nullable: false),
                    Numero = table.Column<int>(type: "INTEGER", nullable: false),
                    Complemento = table.Column<string>(type: "TEXT", nullable: false),
                    Bairro = table.Column<string>(type: "TEXT", nullable: false),
                    Cep = table.Column<string>(type: "TEXT", nullable: false),
                    Whatsapp = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Preco = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipo_loja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_loja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "unidade_produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unidade_produto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "entrada_produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    IdProduto = table.Column<int>(type: "INTEGER", nullable: false),
                    DataOperacao = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entrada_produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_entrada_produto_produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "imagem_produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdProduto = table.Column<int>(type: "INTEGER", nullable: false),
                    Path = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagem_produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imagem_produto_produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "loja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdTipoLoja = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    NomeProprietario = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    Whatsapp = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    ImagemLoja = table.Column<string>(type: "TEXT", nullable: false),
                    Delivery = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_loja_tipo_loja_IdTipoLoja",
                        column: x => x.IdTipoLoja,
                        principalTable: "tipo_loja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "estoque",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdProduto = table.Column<int>(type: "INTEGER", nullable: false),
                    IdLoja = table.Column<int>(type: "INTEGER", nullable: false),
                    IdUnidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estoque", x => x.Id);
                    table.ForeignKey(
                        name: "FK_estoque_loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "loja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_estoque_produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_estoque_unidade_produto_IdUnidade",
                        column: x => x.IdUnidade,
                        principalTable: "unidade_produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataPedido = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IdLoja = table.Column<int>(type: "INTEGER", nullable: false),
                    IdCliente = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pedido_cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pedido_loja_IdLoja",
                        column: x => x.IdLoja,
                        principalTable: "loja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedido_produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPedido = table.Column<int>(type: "INTEGER", nullable: false),
                    IdProduto = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido_produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pedido_produto_pedido_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pedido_produto_produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_entrada_produto_IdProduto",
                table: "entrada_produto",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_estoque_IdLoja",
                table: "estoque",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_estoque_IdProduto",
                table: "estoque",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_estoque_IdUnidade",
                table: "estoque",
                column: "IdUnidade");

            migrationBuilder.CreateIndex(
                name: "IX_imagem_produto_IdProduto",
                table: "imagem_produto",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_loja_IdTipoLoja",
                table: "loja",
                column: "IdTipoLoja");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_IdCliente",
                table: "pedido",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_IdLoja",
                table: "pedido",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_produto_IdPedido",
                table: "pedido_produto",
                column: "IdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_produto_IdProduto",
                table: "pedido_produto",
                column: "IdProduto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "entrada_produto");

            migrationBuilder.DropTable(
                name: "estoque");

            migrationBuilder.DropTable(
                name: "imagem_produto");

            migrationBuilder.DropTable(
                name: "pedido_produto");

            migrationBuilder.DropTable(
                name: "unidade_produto");

            migrationBuilder.DropTable(
                name: "pedido");

            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "loja");

            migrationBuilder.DropTable(
                name: "tipo_loja");
        }
    }
}
