using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesApp.API.Migrations
{
    /// <inheritdoc />
    public partial class DroppingsomeFKsinpreparationforIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Genre_GenresId",
                table: "GenreMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieRating_ApplicationUser_UserId",
                table: "MovieRating");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieRating_Movie_MovieId",
                table: "MovieRating");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReview_ApplicationUser_UserId",
                table: "MovieReview");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReview_Movie_MovieId",
                table: "MovieReview");

            migrationBuilder.DropIndex(
                name: "IX_MovieReview_UserId",
                table: "MovieReview");

            migrationBuilder.DropIndex(
                name: "IX_MovieRating_UserId",
                table: "MovieRating");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MovieReview");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MovieRating");

            migrationBuilder.RenameTable(
                name: "MovieReview",
                newName: "MovieReviews");

            migrationBuilder.RenameTable(
                name: "MovieRating",
                newName: "MovieRatings");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "ApplicationUser",
                newName: "ApplicationUsers");

            migrationBuilder.RenameIndex(
                name: "IX_MovieReview_MovieId",
                table: "MovieReviews",
                newName: "IX_MovieReviews_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieRating_MovieId",
                table: "MovieRatings",
                newName: "IX_MovieRatings_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Genres_GenresId",
                table: "GenreMovie",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRatings_Movie_MovieId",
                table: "MovieRatings",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReviews_Movie_MovieId",
                table: "MovieReviews",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Genres_GenresId",
                table: "GenreMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieRatings_Movie_MovieId",
                table: "MovieRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReviews_Movie_MovieId",
                table: "MovieReviews");

            migrationBuilder.RenameTable(
                name: "MovieReviews",
                newName: "MovieReview");

            migrationBuilder.RenameTable(
                name: "MovieRatings",
                newName: "MovieRating");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameTable(
                name: "ApplicationUsers",
                newName: "ApplicationUser");

            migrationBuilder.RenameIndex(
                name: "IX_MovieReviews_MovieId",
                table: "MovieReview",
                newName: "IX_MovieReview_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieRatings_MovieId",
                table: "MovieRating",
                newName: "IX_MovieRating_MovieId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MovieReview",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MovieRating",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MovieReview_UserId",
                table: "MovieReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRating_UserId",
                table: "MovieRating",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Genre_GenresId",
                table: "GenreMovie",
                column: "GenresId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRating_ApplicationUser_UserId",
                table: "MovieRating",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRating_Movie_MovieId",
                table: "MovieRating",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReview_ApplicationUser_UserId",
                table: "MovieReview",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReview_Movie_MovieId",
                table: "MovieReview",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
