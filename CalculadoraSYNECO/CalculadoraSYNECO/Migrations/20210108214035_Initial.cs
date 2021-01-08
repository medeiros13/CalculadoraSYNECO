using Microsoft.EntityFrameworkCore.Migrations;

namespace CalculadoraSYNECO.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero1 = table.Column<double>(type: "float", nullable: false),
                    Numero2 = table.Column<double>(type: "float", nullable: true),
                    Operacao = table.Column<int>(type: "int", nullable: false),
                    Resultado = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculo");
        }
    }
}
