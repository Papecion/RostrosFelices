using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RostrosFelices.Migrations
{
    /// <inheritdoc />
    public partial class iniiciarr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Clientes_ClienteId",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Empleados_EmpleadoId",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_MetodosDePagos_MetodoDePagoId",
                table: "Servicios");

            migrationBuilder.DropTable(
                name: "MetodosDePagos");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_ClienteId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_EmpleadoId",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Servicios");

            migrationBuilder.RenameColumn(
                name: "MetodoDePagoId",
                table: "Servicios",
                newName: "DatoId");

            migrationBuilder.RenameIndex(
                name: "IX_Servicios_MetodoDePagoId",
                table: "Servicios",
                newName: "IX_Servicios_DatoId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Servicios",
                type: "decimal (6,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddColumn<int>(
                name: "Documento",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Datos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    ServicioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datos", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Datos");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_DatoId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_DatoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "DatoId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "DatoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "DatoId",
                table: "Servicios",
                newName: "MetodoDePagoId");

            migrationBuilder.RenameIndex(
                name: "IX_Servicios_DatoId",
                table: "Servicios",
                newName: "IX_Servicios_MetodoDePagoId");

            migrationBuilder.AlterColumn<string>(
                name: "Precio",
                table: "Servicios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal (6,2)");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Servicios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Servicios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MetodosDePagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodosDePagos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_ClienteId",
                table: "Servicios",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_EmpleadoId",
                table: "Servicios",
                column: "EmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Clientes_ClienteId",
                table: "Servicios",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Empleados_EmpleadoId",
                table: "Servicios",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_MetodosDePagos_MetodoDePagoId",
                table: "Servicios",
                column: "MetodoDePagoId",
                principalTable: "MetodosDePagos",
                principalColumn: "Id");
        }
    }
}
