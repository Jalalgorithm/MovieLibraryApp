using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApp.Migrations
{
    /// <inheritdoc />
    public partial class PopulateGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genres (Name) VALUES('Action')");
            migrationBuilder.Sql("INSERT INTO Genres (Name) VALUES('Romance')");
            migrationBuilder.Sql("INSERT INTO Genres (Name) VALUES('Sci-Fi')");
            migrationBuilder.Sql("INSERT INTO Genres (Name) VALUES('Fantasy')");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Genres WHERE Name IN ('Action' , 'Romance' , 'Sci-Fi' , 'Fantasy')");
        }
    }
}
