using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercadoApp.Entities.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "loja",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Senha",
                table: "loja");
        }
    }
}
