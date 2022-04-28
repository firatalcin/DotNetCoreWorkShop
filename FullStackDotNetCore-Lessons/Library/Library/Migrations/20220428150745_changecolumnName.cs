using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class changecolumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Books_BookId",
                table: "Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Students_StudentId",
                table: "Operations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operations",
                table: "Operations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Operations",
                newName: "Operasyonlar");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Yazarlar");

            migrationBuilder.RenameIndex(
                name: "IX_Operations_BookId",
                table: "Operasyonlar",
                newName: "IX_Operasyonlar_BookId");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Yazarlar",
                newName: "Soyisim");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Yazarlar",
                newName: "Isim");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operasyonlar",
                table: "Operasyonlar",
                columns: new[] { "StudentId", "BookId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yazarlar",
                table: "Yazarlar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Yazarlar_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Yazarlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operasyonlar_Books_BookId",
                table: "Operasyonlar",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operasyonlar_Students_StudentId",
                table: "Operasyonlar",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Yazarlar_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Operasyonlar_Books_BookId",
                table: "Operasyonlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Operasyonlar_Students_StudentId",
                table: "Operasyonlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yazarlar",
                table: "Yazarlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operasyonlar",
                table: "Operasyonlar");

            migrationBuilder.RenameTable(
                name: "Yazarlar",
                newName: "Authors");

            migrationBuilder.RenameTable(
                name: "Operasyonlar",
                newName: "Operations");

            migrationBuilder.RenameColumn(
                name: "Soyisim",
                table: "Authors",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Isim",
                table: "Authors",
                newName: "FirstName");

            migrationBuilder.RenameIndex(
                name: "IX_Operasyonlar_BookId",
                table: "Operations",
                newName: "IX_Operations_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operations",
                table: "Operations",
                columns: new[] { "StudentId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Books_BookId",
                table: "Operations",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Students_StudentId",
                table: "Operations",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
