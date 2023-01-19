using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lamiapizzeriacrudmvc.Migrations
{
    /// <inheritdoc />
    public partial class NomeDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Pizzes_PizzaId",
                table: "Categoria");

            migrationBuilder.RenameColumn(
                name: "PizzaId",
                table: "Categoria",
                newName: "Id1");

            migrationBuilder.RenameIndex(
                name: "IX_Categoria_PizzaId",
                table: "Categoria",
                newName: "IX_Categoria_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Pizzes_Id1",
                table: "Categoria",
                column: "Id1",
                principalTable: "Pizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Pizzes_Id1",
                table: "Categoria");

            migrationBuilder.RenameColumn(
                name: "Id1",
                table: "Categoria",
                newName: "PizzaId");

            migrationBuilder.RenameIndex(
                name: "IX_Categoria_Id1",
                table: "Categoria",
                newName: "IX_Categoria_PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Pizzes_PizzaId",
                table: "Categoria",
                column: "PizzaId",
                principalTable: "Pizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
