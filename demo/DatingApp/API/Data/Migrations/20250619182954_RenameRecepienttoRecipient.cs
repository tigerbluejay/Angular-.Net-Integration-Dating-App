using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameRecepienttoRecipient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_RecepientId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "RecepientUsername",
                table: "Messages",
                newName: "RecipientUsername");

            migrationBuilder.RenameColumn(
                name: "RecepientId",
                table: "Messages",
                newName: "RecipientId");

            migrationBuilder.RenameColumn(
                name: "RecepientDeleted",
                table: "Messages",
                newName: "RecipientDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_RecepientId",
                table: "Messages",
                newName: "IX_Messages_RecipientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_RecipientId",
                table: "Messages",
                column: "RecipientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_RecipientId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "RecipientUsername",
                table: "Messages",
                newName: "RecepientUsername");

            migrationBuilder.RenameColumn(
                name: "RecipientId",
                table: "Messages",
                newName: "RecepientId");

            migrationBuilder.RenameColumn(
                name: "RecipientDeleted",
                table: "Messages",
                newName: "RecepientDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_RecipientId",
                table: "Messages",
                newName: "IX_Messages_RecepientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_RecepientId",
                table: "Messages",
                column: "RecepientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
