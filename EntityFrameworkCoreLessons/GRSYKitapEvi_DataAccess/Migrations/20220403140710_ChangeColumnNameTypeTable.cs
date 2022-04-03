using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    public partial class ChangeColumnNameTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Types",
                newName: "TypeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "Types",
                newName: "Name");
        }
    }
}
