using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RostrosFelices.Migrations
{
    /// <inheritdoc />
    public partial class iniii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Datos_DatoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Datos_DatoId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Datos_DatoId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_DatoId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_DatoId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_DatoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DatoId",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "DatoId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "DatoId",
                table: "Clientes");

            migrationBuilder.CreateIndex(
                name: "IX_Datos_ClienteId",
                table: "Datos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Datos_EmpleadoId",
                table: "Datos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Datos_ServicioId",
                table: "Datos",
                column: "ServicioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Datos_Clientes_ClienteId",
                table: "Datos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Datos_Empleados_EmpleadoId",
                table: "Datos",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Datos_Servicios_ServicioId",
                table: "Datos",
                column: "ServicioId",
                principalTable: "Servicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Datos_Clientes_ClienteId",
                table: "Datos");

            migrationBuilder.DropForeignKey(
                name: "FK_Datos_Empleados_EmpleadoId",
                table: "Datos");

            migrationBuilder.DropForeignKey(
                name: "FK_Datos_Servicios_ServicioId",
                table: "Datos");

            migrationBuilder.DropIndex(
                name: "IX_Datos_ClienteId",
                table: "Datos");

            migrationBuilder.DropIndex(
                name: "IX_Datos_EmpleadoId",
                table: "Datos");

            migrationBuilder.DropIndex(
                name: "IX_Datos_ServicioId",
                table: "Datos");

            migrationBuilder.AddColumn<int>(
                name: "DatoId",
                table: "Servicios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DatoId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DatoId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_DatoId",
                table: "Servicios",
                column: "DatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DatoId",
                table: "Empleados",
                column: "DatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DatoId",
                table: "Clientes",
                column: "DatoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Datos_DatoId",
                table: "Clientes",
                column: "DatoId",
                principalTable: "Datos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Datos_DatoId",
                table: "Empleados",
                column: "DatoId",
                principalTable: "Datos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Datos_DatoId",
                table: "Servicios",
                column: "DatoId",
                principalTable: "Datos",
                principalColumn: "Id");
        }
    }
}
