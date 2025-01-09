using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shared.Database.MainDatabase.Migrations
{
    /// <inheritdoc />
    public partial class _001Add_Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    IsActiv = table.Column<bool>(type: "bit", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "main_messages",
                columns: table => new
                {
                    UniqId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    message_body = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_main_messages", x => x.UniqId);
                    table.ForeignKey(
                        name: "FK_main_messages_Users_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "FirstName", "Gender", "IsActiv", "PasswordHash", "PasswordSalt", "SecondName" },
                values: new object[] { 1, 50, "admin@mail.com", "Admin", true, null, "password", "password1", "Main" });

            migrationBuilder.CreateIndex(
                name: "IX_main_messages_AuthorID",
                table: "main_messages",
                column: "AuthorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "main_messages");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
