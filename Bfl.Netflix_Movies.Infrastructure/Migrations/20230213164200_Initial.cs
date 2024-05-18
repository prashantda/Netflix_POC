using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bfl.Netflix.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Casts",
                columns: table => new
                {
                    CastId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casts", x => x.CastId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ChapterNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "TvShows",
                columns: table => new
                {
                    TvShowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TvShowName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Seasons = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    CreatorName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    TrailerPath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShows", x => x.TvShowId);
                });

            migrationBuilder.CreateTable(
                name: "MovieCast",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CastId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCast", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieCast_Casts_CastId",
                        column: x => x.CastId,
                        principalTable: "Casts",
                        principalColumn: "CastId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCast_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCategory_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    EpisodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EpisodeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TvShowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    VideoPath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.EpisodeId);
                    table.ForeignKey(
                        name: "FK_Episodes_TvShows_TvShowId",
                        column: x => x.TvShowId,
                        principalTable: "TvShows",
                        principalColumn: "TvShowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TvShowCast",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TvShowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CastId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShowCast", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TvShowCast_Casts_CastId",
                        column: x => x.CastId,
                        principalTable: "Casts",
                        principalColumn: "CastId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TvShowCast_TvShows_TvShowId",
                        column: x => x.TvShowId,
                        principalTable: "TvShows",
                        principalColumn: "TvShowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TvShowCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TvShowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShowCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TvShowCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TvShowCategory_TvShows_TvShowId",
                        column: x => x.TvShowId,
                        principalTable: "TvShows",
                        principalColumn: "TvShowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "CastId", "CastName" },
                values: new object[,]
                {
                    { new Guid("0432031c-79dd-49e0-a3f7-59221fef55a7"), "Anushka Shetty" },
                    { new Guid("107ca531-68f0-4b34-a6ff-efd0d12d0110"), "Amol Palekar" },
                    { new Guid("1268244c-fb2c-4ee6-b25c-e89e08e23950"), "Madhubala" },
                    { new Guid("15b0a214-e36f-4101-b911-83e16a9dfcdd"), "Rajkummar Rao" },
                    { new Guid("195f3652-c390-4705-9f75-d88ce27dacaf"), "Tapasi Pannu" },
                    { new Guid("207cc525-5a71-4a2c-b317-f757d8a49753"), "Aliya Bhatt" },
                    { new Guid("23cee9a2-b0e5-44ad-892c-9c3184322ab0"), "Anil Kapoor" },
                    { new Guid("2af3e4e3-32c1-4b5d-8555-7aaf7054c13e"), "Deepika Padukone" },
                    { new Guid("479f8f66-2cb5-499e-8509-daf98918bec8"), "ABC" },
                    { new Guid("48114c9e-e646-4dd7-98ae-06e2d0f82829"), "Sai Pallavi" },
                    { new Guid("4c774386-0b7f-432e-8a6f-44f2f84aac73"), "Samantha Prabhu" },
                    { new Guid("5404c987-6146-453c-9611-5f85119b74c7"), "Amitabh Bachchan" },
                    { new Guid("57c94d5c-55bd-4452-88d6-6ea9b05123ec"), "Kiaara Adavani" },
                    { new Guid("5abbb589-ed12-42aa-b6a4-78b32d562a14"), "Sushant Sing Rajpoot" },
                    { new Guid("64e9cafa-a883-4719-abff-f6c530ec9ede"), "Akshaye Khanna" },
                    { new Guid("72eba14e-4cb5-4862-8c79-f844966e39d3"), "Ranvir Kapoor" },
                    { new Guid("8c2c6d0d-6063-4b11-ac65-bbdcb3e58719"), "Akshay Kumar" },
                    { new Guid("8c5cf78e-58c3-437a-9bbf-0b446a419f51"), "Amjad Khan" },
                    { new Guid("95cad04c-bb57-40e3-8ed8-6fd1ac3e81ce"), "Aamir Khan" },
                    { new Guid("98f024b8-3b31-43c7-b6f9-17a486e88b3d"), "Ajay Devgn" },
                    { new Guid("a5ff9ba3-b615-43d4-af0e-5a13d2605f81"), "Tabu" },
                    { new Guid("c5435d6a-eb1c-43b5-8eae-b0f4a0f0661a"), "Shradhaa Kapoor" },
                    { new Guid("f6fa91d4-777c-439f-8350-da1b15938c98"), "Madhuri Dixit" },
                    { new Guid("f70a5658-9d2c-4746-a22c-98322c14e16c"), "Ayushmann Khurrana" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("012107df-862f-4f16-ba94-e5c16886f005"), "Hollywood" },
                    { new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), "Stand-Up" },
                    { new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"), "Thrillers" },
                    { new Guid("28d11936-9466-4a4b-b9c5-2f0a8e0cbde9"), "International" },
                    { new Guid("29339209-63f5-492f-8459-754943c74abf"), "Dramas" },
                    { new Guid("2a6d3738-9def-43ac-9279-0310edc7ceca"), "Documentries" },
                    { new Guid("501c6d13-1bbe-48f1-4fbd-2275913c6216"), "Reality" },
                    { new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"), "Romance" },
                    { new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), "Biographical" },
                    { new Guid("89e5f445-d89f-4e12-94e0-5ad5b235d704"), "Comedies" },
                    { new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"), "Sci-Fi" },
                    { new Guid("a3b9833b-8a4d-43e9-8690-61e08df81a9a"), "Musicals" },
                    { new Guid("ac660a73-b0b7-4340-abc1-a914257a6189"), "Fantasy" },
                    { new Guid("c03bbe45-9aeb-4d24-99e0-4743016ffce9"), "Award Winners" },
                    { new Guid("c3abddbd-cf50-41d2-b6c4-cc7d5a750928"), "Blockbusters" },
                    { new Guid("c6d50a47-f7e6-4482-8be0-4ddfc057fa6e"), "Bollywood" },
                    { new Guid("cb035f22-e7cf-4907-bd07-91cfee5240f3"), "Horrer" },
                    { new Guid("d15c6d9f-70b4-48c5-afd3-e71261f1a9be"), "Kids and Family" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_TvShowId",
                table: "Episodes",
                column: "TvShowId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCast_CastId",
                table: "MovieCast",
                column: "CastId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCast_MovieId",
                table: "MovieCast",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCategory_CategoryId",
                table: "MovieCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCategory_MovieId",
                table: "MovieCategory",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_TvShowCast_CastId",
                table: "TvShowCast",
                column: "CastId");

            migrationBuilder.CreateIndex(
                name: "IX_TvShowCast_TvShowId",
                table: "TvShowCast",
                column: "TvShowId");

            migrationBuilder.CreateIndex(
                name: "IX_TvShowCategory_CategoryId",
                table: "TvShowCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TvShowCategory_TvShowId",
                table: "TvShowCategory",
                column: "TvShowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "MovieCast");

            migrationBuilder.DropTable(
                name: "MovieCategory");

            migrationBuilder.DropTable(
                name: "TvShowCast");

            migrationBuilder.DropTable(
                name: "TvShowCategory");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Casts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TvShows");
        }
    }
}
