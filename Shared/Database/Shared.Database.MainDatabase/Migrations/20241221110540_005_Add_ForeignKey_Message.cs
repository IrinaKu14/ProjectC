using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shared.Database.MainDatabase.Migrations
{
    /// <inheritdoc />
    public partial class _005_Add_ForeignKey_Message : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_AuthorID",
                table: "Messages",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_AuthorID",
                table: "Messages",
                column: "AuthorID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_AuthorID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_AuthorID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Messages");
        }
    }
}
