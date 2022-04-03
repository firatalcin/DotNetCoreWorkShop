﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GRSYKitapEvi_DataAccess.Migrations
{
    public partial class AddDisplayOrderPropertyTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Types",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Types");
        }
    }
}
