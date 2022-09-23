using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Razor.Migrations
{
    public partial class tableShoppingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "admin",
                keyColumn: "id",
                keyValue: "1f35a5c1-f0c7-483b-8058-ea4adf138ac2");

            migrationBuilder.AddColumn<string>(
                name: "ShoppingCartId",
                table: "produto",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "cliente",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "shoppingCartId",
                table: "cliente",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "admin",
                columns: new[] { "id", "nome", "senha" },
                values: new object[] { "caa82ac9-8d80-452b-9b21-1d5ebf87ed18", "sa", "1234" });

            migrationBuilder.CreateIndex(
                name: "IX_produto_ShoppingCartId",
                table: "produto",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_shoppingCartId",
                table: "cliente",
                column: "shoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_ShoppingCart_shoppingCartId",
                table: "cliente",
                column: "shoppingCartId",
                principalTable: "ShoppingCart",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_produto_ShoppingCart_ShoppingCartId",
                table: "produto",
                column: "ShoppingCartId",
                principalTable: "ShoppingCart",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cliente_ShoppingCart_shoppingCartId",
                table: "cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_produto_ShoppingCart_ShoppingCartId",
                table: "produto");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_produto_ShoppingCartId",
                table: "produto");

            migrationBuilder.DropIndex(
                name: "IX_cliente_shoppingCartId",
                table: "cliente");

            migrationBuilder.DeleteData(
                table: "admin",
                keyColumn: "id",
                keyValue: "caa82ac9-8d80-452b-9b21-1d5ebf87ed18");

            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "produto");

            migrationBuilder.DropColumn(
                name: "shoppingCartId",
                table: "cliente");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "cliente",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "admin",
                columns: new[] { "id", "nome", "senha" },
                values: new object[] { "1f35a5c1-f0c7-483b-8058-ea4adf138ac2", "sa", "1234" });
        }
    }
}
