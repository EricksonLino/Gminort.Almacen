using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gminort.Almacen.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class CantidadAEntero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "Productos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cantidad",
                table: "Productos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
