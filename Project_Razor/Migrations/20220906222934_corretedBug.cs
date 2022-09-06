using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Razor.Migrations
{
    public partial class corretedBug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    id = table.Column<string>(type: "TEXT", nullable: false),
                    nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    senha = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "varchar(11)", nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(50)", nullable: false),
                    nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    descricao = table.Column<string>(type: "varchar(50)", nullable: false),
                    preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    estoque = table.Column<int>(type: "INTEGER", nullable: false),
                    imageName = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "admin",
                columns: new[] { "id", "nome", "senha" },
                values: new object[] { "8af290db-69fa-4fae-ad44-58e3be7bb94a", "sa", "1234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "produto");
        }
    }
}
