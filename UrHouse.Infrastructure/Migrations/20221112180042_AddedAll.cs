using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrHouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PriceOffers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PromotionalText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApartamentId = table.Column<int>(type: "int", nullable: false),
                    AppartamentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceOffers_Apartament_AppartamentId",
                        column: x => x.AppartamentId,
                        principalTable: "Apartament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumStars = table.Column<short>(type: "smallint", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApartamentId = table.Column<int>(type: "int", nullable: false),
                    ApartamentId1 = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Apartament_ApartamentId1",
                        column: x => x.ApartamentId1,
                        principalTable: "Apartament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PriceOffers_AppartamentId",
                table: "PriceOffers",
                column: "AppartamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_ApartamentId1",
                table: "Review",
                column: "ApartamentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceOffers");

            migrationBuilder.DropTable(
                name: "Review");
        }
    }
}
