using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberAwareness.Migrations
{
    /// <inheritdoc />
    public partial class testJuncTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Segments_Categories_CategoryModelId",
                table: "Segments");

            migrationBuilder.DropIndex(
                name: "IX_Segments_CategoryModelId",
                table: "Segments");

            migrationBuilder.DropColumn(
                name: "CategoryModelId",
                table: "Segments");

            migrationBuilder.CreateTable(
                name: "CategoryModelSegmentModel",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    SegmentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModelSegmentModel", x => new { x.CategoriesId, x.SegmentsId });
                    table.ForeignKey(
                        name: "FK_CategoryModelSegmentModel_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryModelSegmentModel_Segments_SegmentsId",
                        column: x => x.SegmentsId,
                        principalTable: "Segments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryModelSegmentModel_SegmentsId",
                table: "CategoryModelSegmentModel",
                column: "SegmentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryModelSegmentModel");

            migrationBuilder.AddColumn<int>(
                name: "CategoryModelId",
                table: "Segments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Segments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryModelId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Segments_CategoryModelId",
                table: "Segments",
                column: "CategoryModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Segments_Categories_CategoryModelId",
                table: "Segments",
                column: "CategoryModelId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
