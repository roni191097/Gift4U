using Microsoft.EntityFrameworkCore.Migrations;

namespace Gift4U.Migrations
{
    public partial class Contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreSale_Sale_SaleId",
                table: "StoreSale");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreSale_Stores_StoreID",
                table: "StoreSale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreSale",
                table: "StoreSale");

            migrationBuilder.DropIndex(
                name: "IX_StoreSale_SaleId",
                table: "StoreSale");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StoreSale");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreSale",
                table: "StoreSale",
                columns: new[] { "SaleId", "StoreID" });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Telephone = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StoreSale_Stores_SaleId",
                table: "StoreSale",
                column: "SaleId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreSale_Sale_StoreID",
                table: "StoreSale",
                column: "StoreID",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreSale_Stores_SaleId",
                table: "StoreSale");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreSale_Sale_StoreID",
                table: "StoreSale");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreSale",
                table: "StoreSale");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StoreSale",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreSale",
                table: "StoreSale",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StoreSale_SaleId",
                table: "StoreSale",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreSale_Sale_SaleId",
                table: "StoreSale",
                column: "SaleId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreSale_Stores_StoreID",
                table: "StoreSale",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
