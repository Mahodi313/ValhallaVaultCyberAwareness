using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValhallaVaultCyberAwareness.Migrations
{
    /// <inheritdoc />
    public partial class testJuncTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerModel_QuestionModel_QuestionId",
                table: "AnswerModel");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionModel_SubcategoryModel_SubcategoryId",
                table: "QuestionModel");

            migrationBuilder.DropForeignKey(
                name: "FK_SegmentModel_Categories_CategoryId",
                table: "SegmentModel");

            migrationBuilder.DropForeignKey(
                name: "FK_SubcategoryModel_SegmentModel_SegmentId",
                table: "SubcategoryModel");

            migrationBuilder.DropForeignKey(
                name: "FK_UserResponseModel_AspNetUsers_UserId",
                table: "UserResponseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_UserResponseModel_QuestionModel_QuestionId",
                table: "UserResponseModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserResponseModel",
                table: "UserResponseModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubcategoryModel",
                table: "SubcategoryModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SegmentModel",
                table: "SegmentModel");

            migrationBuilder.DropIndex(
                name: "IX_SegmentModel_CategoryId",
                table: "SegmentModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionModel",
                table: "QuestionModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerModel",
                table: "AnswerModel");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "SegmentModel");

            migrationBuilder.RenameTable(
                name: "UserResponseModel",
                newName: "UserResponses");

            migrationBuilder.RenameTable(
                name: "SubcategoryModel",
                newName: "Subcategories");

            migrationBuilder.RenameTable(
                name: "SegmentModel",
                newName: "Segments");

            migrationBuilder.RenameTable(
                name: "QuestionModel",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "AnswerModel",
                newName: "Answers");

            migrationBuilder.RenameIndex(
                name: "IX_UserResponseModel_UserId",
                table: "UserResponses",
                newName: "IX_UserResponses_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserResponseModel_QuestionId",
                table: "UserResponses",
                newName: "IX_UserResponses_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_SubcategoryModel_SegmentId",
                table: "Subcategories",
                newName: "IX_Subcategories_SegmentId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionModel_SubcategoryId",
                table: "Questions",
                newName: "IX_Questions_SubcategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_AnswerModel_QuestionId",
                table: "Answers",
                newName: "IX_Answers_QuestionId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryModelId",
                table: "Segments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Explanation",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserResponses",
                table: "UserResponses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subcategories",
                table: "Subcategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Segments",
                table: "Segments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Att skydda sig mot bedrägerier" },
                    { 2, "Cybersäkerhet för företag" },
                    { 3, "Cyberspionage" }
                });

            migrationBuilder.InsertData(
                table: "Segments",
                columns: new[] { "Id", "CategoryModelId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Del 1" },
                    { 2, null, "Del 2" },
                    { 3, null, "Del 3" },
                    { 4, null, "Del 4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Segments_CategoryModelId",
                table: "Segments",
                column: "CategoryModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Subcategories_SubcategoryId",
                table: "Questions",
                column: "SubcategoryId",
                principalTable: "Subcategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Segments_Categories_CategoryModelId",
                table: "Segments",
                column: "CategoryModelId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategories_Segments_SegmentId",
                table: "Subcategories",
                column: "SegmentId",
                principalTable: "Segments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserResponses_AspNetUsers_UserId",
                table: "UserResponses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserResponses_Questions_QuestionId",
                table: "UserResponses",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Subcategories_SubcategoryId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Segments_Categories_CategoryModelId",
                table: "Segments");

            migrationBuilder.DropForeignKey(
                name: "FK_Subcategories_Segments_SegmentId",
                table: "Subcategories");

            migrationBuilder.DropForeignKey(
                name: "FK_UserResponses_AspNetUsers_UserId",
                table: "UserResponses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserResponses_Questions_QuestionId",
                table: "UserResponses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserResponses",
                table: "UserResponses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subcategories",
                table: "Subcategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Segments",
                table: "Segments");

            migrationBuilder.DropIndex(
                name: "IX_Segments_CategoryModelId",
                table: "Segments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "CategoryModelId",
                table: "Segments");

            migrationBuilder.DropColumn(
                name: "Explanation",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "UserResponses",
                newName: "UserResponseModel");

            migrationBuilder.RenameTable(
                name: "Subcategories",
                newName: "SubcategoryModel");

            migrationBuilder.RenameTable(
                name: "Segments",
                newName: "SegmentModel");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "QuestionModel");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "AnswerModel");

            migrationBuilder.RenameIndex(
                name: "IX_UserResponses_UserId",
                table: "UserResponseModel",
                newName: "IX_UserResponseModel_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserResponses_QuestionId",
                table: "UserResponseModel",
                newName: "IX_UserResponseModel_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Subcategories_SegmentId",
                table: "SubcategoryModel",
                newName: "IX_SubcategoryModel_SegmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_SubcategoryId",
                table: "QuestionModel",
                newName: "IX_QuestionModel_SubcategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionId",
                table: "AnswerModel",
                newName: "IX_AnswerModel_QuestionId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "SegmentModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserResponseModel",
                table: "UserResponseModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubcategoryModel",
                table: "SubcategoryModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SegmentModel",
                table: "SegmentModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionModel",
                table: "QuestionModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswerModel",
                table: "AnswerModel",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentModel_CategoryId",
                table: "SegmentModel",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerModel_QuestionModel_QuestionId",
                table: "AnswerModel",
                column: "QuestionId",
                principalTable: "QuestionModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionModel_SubcategoryModel_SubcategoryId",
                table: "QuestionModel",
                column: "SubcategoryId",
                principalTable: "SubcategoryModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SegmentModel_Categories_CategoryId",
                table: "SegmentModel",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubcategoryModel_SegmentModel_SegmentId",
                table: "SubcategoryModel",
                column: "SegmentId",
                principalTable: "SegmentModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserResponseModel_AspNetUsers_UserId",
                table: "UserResponseModel",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserResponseModel_QuestionModel_QuestionId",
                table: "UserResponseModel",
                column: "QuestionId",
                principalTable: "QuestionModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
