﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercadoApp.Entities.Migrations
{
    /// <inheritdoc />
    public partial class UpdateI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "tipo_loja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "produto",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "tipo_loja");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "produto");
        }
    }
}
