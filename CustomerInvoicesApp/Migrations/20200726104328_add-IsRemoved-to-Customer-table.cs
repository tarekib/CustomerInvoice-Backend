using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerInvoicesApp.Migrations
{
    public partial class addIsRemovedtoCustomertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Customers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Customers");
        }
    }
}
