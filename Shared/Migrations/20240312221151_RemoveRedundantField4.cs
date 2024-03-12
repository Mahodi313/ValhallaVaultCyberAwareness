using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberAwareness.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRedundantField4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserResponses_Answers_AnswerModelId",
                table: "UserResponses");

            migrationBuilder.DropIndex(
                name: "IX_UserResponses_AnswerModelId",
                table: "UserResponses");

            migrationBuilder.DropColumn(
                name: "AnswerModelId",
                table: "UserResponses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnswerModelId",
                table: "UserResponses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserResponses_AnswerModelId",
                table: "UserResponses",
                column: "AnswerModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserResponses_Answers_AnswerModelId",
                table: "UserResponses",
                column: "AnswerModelId",
                principalTable: "Answers",
                principalColumn: "Id");
        }
    }
}
