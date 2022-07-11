using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AP2_Verduras.Migrations
{
    public partial class Agregueelmodelcreatingalcontexto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedida" },
                values: new object[] { 1, "Vitamina C (mg)", 120.0 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedida" },
                values: new object[] { 2, "Vitamina E (mg)", 1.54 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedida" },
                values: new object[] { 3, "Vitamina K (mcg)", 390.0 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedida" },
                values: new object[] { 4, "Vitamina A (mcg RAE)", 90.0 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedida" },
                values: new object[] { 5, "Betaína (mg)", 700.0 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedida" },
                values: new object[] { 6, "Tiamina(B1) (mg)", 0.11 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedida" },
                values: new object[] { 7, "Riboflavina(B2) (mg)", 0.13 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedida" },
                values: new object[] { 8, "Ácido fólico(B9) (mg)", 400.0 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedida" },
                values: new object[] { 9, "Choline (mg)", 0.80000000000000004 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedida" },
                values: new object[] { 10, "Folate(B9) (μg)", 141.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 10);
        }
    }
}
