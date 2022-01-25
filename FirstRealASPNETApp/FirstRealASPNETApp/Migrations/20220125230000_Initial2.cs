using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstRealASPNETApp.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "movies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action", "Christopher Nolan", false, null, null, "PG-13", "The Dark Knight", 2008 });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Action", "Jon Watts", false, null, null, "PG-13", "Spiderman No Way Home", 2021 });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Action", "Paul Greengrass", false, null, null, "PG-13", "The Bourne Ultimatum", 2007 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "category",
                table: "movies");
        }
    }
}
