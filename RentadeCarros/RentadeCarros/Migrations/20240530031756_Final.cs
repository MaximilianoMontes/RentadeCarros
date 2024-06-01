using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentadeCarros.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuariosId",
                table: "Reservaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculosId",
                table: "Reservaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_UsuariosId",
                table: "Reservaciones",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_VehiculosId",
                table: "Reservaciones",
                column: "VehiculosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservaciones_Usuarios_UsuariosId",
                table: "Reservaciones",
                column: "UsuariosId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservaciones_Vehiculos_VehiculosId",
                table: "Reservaciones",
                column: "VehiculosId",
                principalTable: "Vehiculos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservaciones_Usuarios_UsuariosId",
                table: "Reservaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservaciones_Vehiculos_VehiculosId",
                table: "Reservaciones");

            migrationBuilder.DropIndex(
                name: "IX_Reservaciones_UsuariosId",
                table: "Reservaciones");

            migrationBuilder.DropIndex(
                name: "IX_Reservaciones_VehiculosId",
                table: "Reservaciones");

            migrationBuilder.DropColumn(
                name: "UsuariosId",
                table: "Reservaciones");

            migrationBuilder.DropColumn(
                name: "VehiculosId",
                table: "Reservaciones");
        }
    }
}
