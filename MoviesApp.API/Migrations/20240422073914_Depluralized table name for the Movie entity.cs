using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesApp.API.Migrations
{
    /// <inheritdoc />
    public partial class DepluralizedtablenamefortheMovieentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Movies_MoviesId",
                table: "GenreMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieRating_Movies_MovieId",
                table: "MovieRating");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReview_Movies_MovieId",
                table: "MovieReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Movie_MoviesId",
                table: "GenreMovie",
                column: "MoviesId",
                principalTable: "Movie",
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
                name: "FK_MovieReview_Movie_MovieId",
                table: "MovieReview",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Movie_MoviesId",
                table: "GenreMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieRating_Movie_MovieId",
                table: "MovieRating");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReview_Movie_MovieId",
                table: "MovieReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Movies_MoviesId",
                table: "GenreMovie",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRating_Movies_MovieId",
                table: "MovieRating",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReview_Movies_MovieId",
                table: "MovieReview",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
