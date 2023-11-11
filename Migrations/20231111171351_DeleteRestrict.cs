using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumorHub.Migrations
{
    /// <inheritdoc />
    public partial class DeleteRestrict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jokes_Categories_CategoryId",
                table: "Jokes");

            migrationBuilder.AddForeignKey(
                name: "FK_Jokes_Categories_CategoryId",
                table: "Jokes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jokes_Categories_CategoryId",
                table: "Jokes");

            migrationBuilder.AddForeignKey(
                name: "FK_Jokes_Categories_CategoryId",
                table: "Jokes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
