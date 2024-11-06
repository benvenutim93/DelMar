using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DelMar.DB.Migrations
{
    /// <inheritdoc />
    public partial class Creacion_DB_inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Configuraciones",
                columns: table => new
                {
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColumnaNombreLista = table.Column<int>(type: "int", nullable: false),
                    ColumnaPrecioCosto = table.Column<int>(type: "int", nullable: false),
                    ColumnaCodigoExterno = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuraciones", x => x.IdProveedor);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreLista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contenido = table.Column<int>(type: "int", nullable: false),
                    Unidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioCosto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Porcentaje = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrecioVenta = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CodigoExterno = table.Column<int>(type: "int", nullable: true),
                    IdCategoriaNavigationId = table.Column<int>(type: "int", nullable: true),
                    IdProveedorNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articulos_Categorias_IdCategoriaNavigationId",
                        column: x => x.IdCategoriaNavigationId,
                        principalTable: "Categorias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Articulos_Proveedores_IdProveedorNavigationId",
                        column: x => x.IdProveedorNavigationId,
                        principalTable: "Proveedores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_IdCategoriaNavigationId",
                table: "Articulos",
                column: "IdCategoriaNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_IdProveedorNavigationId",
                table: "Articulos",
                column: "IdProveedorNavigationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos");

            migrationBuilder.DropTable(
                name: "Configuraciones");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}
