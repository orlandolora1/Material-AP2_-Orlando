using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AP2_Verduras.Migrations
{
    public partial class CambiecampodeVitaminas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "UnidadDeMedida",
                table: "Vitaminas",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UnidadDeMedida",
                table: "Vitaminas",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");
        }
    }
}
