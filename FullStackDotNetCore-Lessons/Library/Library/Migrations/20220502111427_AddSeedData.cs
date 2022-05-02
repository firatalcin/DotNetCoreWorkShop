using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDay", "CreatedDate", "FirstName", "Gender", "LastName", "ModifiedDate", "PhoneNumber", "SchoolNumber", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 14, 14, 26, 720, DateTimeKind.Local).AddTicks(6238), "Fırat", 0, "Alçın", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 14, 14, 26, 720, DateTimeKind.Local).AddTicks(8378), "Enes", 0, "Çiçek", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 14, 14, 26, 720, DateTimeKind.Local).AddTicks(8392), "Sibel", 1, "Doruk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 14, 14, 26, 720, DateTimeKind.Local).AddTicks(8395), "Hatice", 1, "Akkoçan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "Password", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 2, 14, 14, 26, 712, DateTimeKind.Local).AddTicks(5538), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$.2TvPcavmSVfcZH5EnrcNeSmFTtDs/TQ5byl3Y9BorDR/CeLy9aD.", 1, 1, "administrator" },
                    { 2, new DateTime(2022, 5, 2, 14, 14, 26, 718, DateTimeKind.Local).AddTicks(5537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$vH0xOzPUOjuh6xr7xR/ROugB5UcHJ5PbKMc82O4AhZ0tdbZeJRE.m", 2, 1, "firat" }
                });

            migrationBuilder.InsertData(
                table: "StudentDetails",
                columns: new[] { "Id", "BirthDay", "CreatedDate", "ModifiedDate", "PhoneNumber", "SchoolNumber", "Status", "StudentId" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 14, 14, 26, 720, DateTimeKind.Local).AddTicks(9456), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "100", 1, 1 },
                    { 2, new DateTime(1998, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 14, 14, 26, 721, DateTimeKind.Local).AddTicks(977), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "101", 1, 2 },
                    { 3, new DateTime(1998, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 14, 14, 26, 721, DateTimeKind.Local).AddTicks(986), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "102", 1, 3 },
                    { 4, new DateTime(1998, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 14, 14, 26, 721, DateTimeKind.Local).AddTicks(988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "103", 1, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
