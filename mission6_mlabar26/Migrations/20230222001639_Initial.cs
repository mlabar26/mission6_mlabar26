using Microsoft.EntityFrameworkCore.Migrations;

namespace mission6_mlabar26.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    movieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<string>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lent = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.movieID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieID", "category", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action/Adventure", "Christopher Nolan", false, null, "Great acting, great story!", "PG-13", "The Dark Knight", "2008" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieID", "category", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Comedy", "Christopher Nolan", false, null, null, "PG-13", "Hot Rod", "2007" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieID", "category", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Action/Adventure", "Akiva Schaffer", false, null, "Love the soundtrack!", "PG-13", "Interstellar", "2014" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
