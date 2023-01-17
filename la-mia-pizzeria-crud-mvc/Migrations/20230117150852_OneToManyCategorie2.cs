using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lamiapizzeriacrudmvc.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyCategorie2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Categoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Categoria",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
