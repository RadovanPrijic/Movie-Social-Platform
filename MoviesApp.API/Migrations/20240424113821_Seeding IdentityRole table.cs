using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoviesApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingIdentityRoletable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4066da82-f923-4a73-ae50-a29a5c76c5c1", "4066da82-f923-4a73-ae50-a29a5c76c5c1", "Basic_User", "BASIC_USER" },
                    { "53fee358-1930-4d37-8c9c-4225365c33c1", "53fee358-1930-4d37-8c9c-4225365c33c1", "Admin", "ADMIN" },
                    { "c15e545b-fe60-4307-a970-41f1111e0b0f", "c15e545b-fe60-4307-a970-41f1111e0b0f", "Movie_Critic", "MOVIE_CRITIC" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4066da82-f923-4a73-ae50-a29a5c76c5c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53fee358-1930-4d37-8c9c-4225365c33c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c15e545b-fe60-4307-a970-41f1111e0b0f");
        }
    }
}
