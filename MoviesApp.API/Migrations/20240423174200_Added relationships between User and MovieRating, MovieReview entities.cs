using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesApp.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedrelationshipsbetweenUserandMovieRatingMovieReviewentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "MovieReviews",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "MovieRatings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_MovieReviews_UserId",
                table: "MovieReviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRatings_UserId",
                table: "MovieRatings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRatings_AspNetUsers_UserId",
                table: "MovieRatings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReviews_AspNetUsers_UserId",
                table: "MovieReviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieRatings_AspNetUsers_UserId",
                table: "MovieRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReviews_AspNetUsers_UserId",
                table: "MovieReviews");

            migrationBuilder.DropIndex(
                name: "IX_MovieReviews_UserId",
                table: "MovieReviews");

            migrationBuilder.DropIndex(
                name: "IX_MovieRatings_UserId",
                table: "MovieRatings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MovieReviews");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MovieRatings");
        }
    }
}
