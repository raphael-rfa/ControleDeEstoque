using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeEstoque.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateWithoutAzure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QntProduzida = table.Column<int>(type: "int", nullable: false),
                    QntVendida = table.Column<int>(type: "int", nullable: false),
                    QntEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
