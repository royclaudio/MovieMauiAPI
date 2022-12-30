using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieMauiAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Boxoffice = table.Column<string>(name: "Box_office", type: "TEXT", nullable: true),
                    Director = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    imdbID = table.Column<string>(type: "TEXT", nullable: true),
                    Poster = table.Column<string>(type: "TEXT", nullable: true),
                    Metascore = table.Column<string>(type: "TEXT", nullable: true),
                    Language = table.Column<string>(type: "TEXT", nullable: true),
                    Writer = table.Column<string>(type: "TEXT", nullable: true),
                    imdbVotes = table.Column<string>(type: "TEXT", nullable: true),
                    Runtime = table.Column<string>(type: "TEXT", nullable: true),
                    Response = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Actors = table.Column<string>(type: "TEXT", nullable: true),
                    Awards = table.Column<string>(type: "TEXT", nullable: true),
                    imdbRating = table.Column<string>(type: "TEXT", nullable: true),
                    Rated = table.Column<string>(type: "TEXT", nullable: true),
                    Released = table.Column<string>(type: "TEXT", nullable: true),
                    imagefile = table.Column<string>(name: "image_file", type: "TEXT", nullable: true),
                    Musical = table.Column<int>(type: "INTEGER", nullable: false),
                    Family = table.Column<int>(type: "INTEGER", nullable: false),
                    RealityTV = table.Column<int>(name: "Reality_TV", type: "INTEGER", nullable: false),
                    Western = table.Column<int>(type: "INTEGER", nullable: false),
                    Comedy = table.Column<int>(type: "INTEGER", nullable: false),
                    Mystery = table.Column<int>(type: "INTEGER", nullable: false),
                    Music = table.Column<int>(type: "INTEGER", nullable: false),
                    Fantasy = table.Column<int>(type: "INTEGER", nullable: false),
                    News = table.Column<int>(type: "INTEGER", nullable: false),
                    Adventure = table.Column<int>(type: "INTEGER", nullable: false),
                    Documentary = table.Column<int>(type: "INTEGER", nullable: false),
                    Crime = table.Column<int>(type: "INTEGER", nullable: false),
                    Horror = table.Column<int>(type: "INTEGER", nullable: false),
                    Romance = table.Column<int>(type: "INTEGER", nullable: false),
                    SciFi = table.Column<int>(name: "Sci_Fi", type: "INTEGER", nullable: false),
                    Sport = table.Column<int>(type: "INTEGER", nullable: false),
                    Animation = table.Column<int>(type: "INTEGER", nullable: false),
                    Biography = table.Column<int>(type: "INTEGER", nullable: false),
                    War = table.Column<int>(type: "INTEGER", nullable: false),
                    History = table.Column<int>(type: "INTEGER", nullable: false),
                    Action = table.Column<int>(type: "INTEGER", nullable: false),
                    Short = table.Column<int>(type: "INTEGER", nullable: false),
                    Thriller = table.Column<int>(type: "INTEGER", nullable: false),
                    Drama = table.Column<int>(type: "INTEGER", nullable: false),
                    TwoThousand = table.Column<int>(name: "Two_Thousand", type: "INTEGER", nullable: false),
                    Nineties = table.Column<int>(type: "INTEGER", nullable: false),
                    twentytens = table.Column<int>(name: "twenty_tens", type: "INTEGER", nullable: false),
                    eighties = table.Column<int>(type: "INTEGER", nullable: false),
                    NOTRATED = table.Column<int>(name: "NOT_RATED", type: "INTEGER", nullable: false),
                    RatedG = table.Column<int>(name: "Rated_G", type: "INTEGER", nullable: false),
                    PASSED = table.Column<int>(type: "INTEGER", nullable: false),
                    UNRATED = table.Column<int>(type: "INTEGER", nullable: false),
                    TVG = table.Column<int>(name: "TV_G", type: "INTEGER", nullable: false),
                    AO = table.Column<int>(type: "INTEGER", nullable: false),
                    NA = table.Column<int>(name: "N_A", type: "INTEGER", nullable: false),
                    TV14 = table.Column<int>(name: "TV_14", type: "INTEGER", nullable: false),
                    R = table.Column<int>(type: "INTEGER", nullable: false),
                    TVMA = table.Column<int>(name: "TV_MA", type: "INTEGER", nullable: false),
                    PG = table.Column<int>(type: "INTEGER", nullable: false),
                    X = table.Column<int>(type: "INTEGER", nullable: false),
                    PG13 = table.Column<int>(name: "PG_13", type: "INTEGER", nullable: false),
                    NC17 = table.Column<int>(name: "NC_17", type: "INTEGER", nullable: false),
                    MPG = table.Column<int>(name: "M_PG", type: "INTEGER", nullable: false),
                    TVPG = table.Column<int>(name: "TV_PG", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
