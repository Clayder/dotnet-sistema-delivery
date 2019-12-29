using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_sistema_delivery.Migrations
{
    public partial class AtualizandoFornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "supplier",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "supplier");
        }
    }
}
