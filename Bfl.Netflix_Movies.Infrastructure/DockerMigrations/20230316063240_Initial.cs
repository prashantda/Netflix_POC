using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bfl.Netflix_Service1.Infrastructure.DockerMigrations
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
                    ChapterNo = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    CreatorName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    TrailerPath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    VideoPath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Access = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
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
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Access = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShows", x => x.TvShowId);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Subscription = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "MovieCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCategories_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieCats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CastId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieCats_Casts_CastId",
                        column: x => x.CastId,
                        principalTable: "Casts",
                        principalColumn: "CastId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCats_Movies_MovieId",
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
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Access = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "TvShowCasts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TvShowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CastId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShowCasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TvShowCasts_Casts_CastId",
                        column: x => x.CastId,
                        principalTable: "Casts",
                        principalColumn: "CastId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TvShowCasts_TvShows_TvShowId",
                        column: x => x.TvShowId,
                        principalTable: "TvShows",
                        principalColumn: "TvShowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TvShowCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TvShowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShowCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TvShowCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TvShowCategories_TvShows_TvShowId",
                        column: x => x.TvShowId,
                        principalTable: "TvShows",
                        principalColumn: "TvShowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OTP",
                columns: table => new
                {
                    TempUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OTP = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResetToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OTP", x => x.TempUserId);
                    table.ForeignKey(
                        name: "FK_OTP_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "CastId", "CastName" },
                values: new object[,]
                {
                    { new Guid("0d10ebaf-acb4-4b84-a1ef-5f322cb49c6d"), "Shradhaa Kapoor" },
                    { new Guid("0e1798d8-8940-46c1-8984-6c4d467a25d1"), "Amitabh Bachchan" },
                    { new Guid("1464e46b-6db6-4ab5-8b9c-01e4b993dc83"), "Aliya Bhatt" },
                    { new Guid("16a1438d-99cf-47ee-9420-d6d3541b3337"), "Kiaara Adavani" },
                    { new Guid("2219dc4c-6e3a-4c14-9bfc-1051a632f6f7"), "Deepika Padukone" },
                    { new Guid("25a69192-3745-4fed-854e-0077f830dbea"), "Akshaye Khanna" },
                    { new Guid("32a16541-0df0-4977-a925-4a70861e265b"), "Amol Palekar" },
                    { new Guid("52a40988-5c35-4ce1-9cbb-930871aab635"), "Tabu" },
                    { new Guid("58e9c53a-e15f-43fb-92b0-a25c072f0388"), "Anil Kapoor" },
                    { new Guid("63a43268-e4e7-47fc-b4bb-13e96010c3ef"), "Madhuri Dixit" },
                    { new Guid("6469eafe-5a40-4f37-a412-1506c37e252f"), "Ayushmann Khurrana" },
                    { new Guid("6c5b33ee-64cf-4435-a6e9-032080c04784"), "Samantha Prabhu" },
                    { new Guid("6f0884d9-7e35-47cf-b3a5-e82ad44f7901"), "ABC" },
                    { new Guid("7a0f0ca0-57d0-4563-b136-9ba098ea3038"), "Amjad Khan" },
                    { new Guid("8bd60bc9-060b-4f0e-a589-d55fb22712ff"), "Ajay Devgn" },
                    { new Guid("8defa795-b1f3-4a64-924e-48ab494ab9b8"), "Sai Pallavi" },
                    { new Guid("98aacfe6-def0-4623-b92b-4f3b89580ec8"), "Tapasi Pannu" },
                    { new Guid("adfd5fc9-57bc-4ee5-bc1d-1862a36bfab5"), "Akshay Kumar" },
                    { new Guid("b21599a6-05dc-44fb-aa06-32d8c3df473f"), "Madhubala" },
                    { new Guid("cfdc5ca1-1d74-481a-858e-203fdd61050a"), "Aamir Khan" },
                    { new Guid("d03c4534-f589-47aa-b270-e8e3da796304"), "Rajkummar Rao" },
                    { new Guid("e03dca37-956d-4efb-8f3d-dbd2944e367b"), "Sushant Sing Rajpoot" },
                    { new Guid("eac31d53-32a5-4deb-83bb-b4cb929e5219"), "Ranvir Kapoor" },
                    { new Guid("fd217b3d-5d47-4b92-88fd-adc186f38e06"), "Anushka Shetty" }
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0313b580-93d9-4677-b4f2-5924509b63b0"), "2e95b8e1-3e50-4748-87c9-7b0f5e61b6df", "Gold", "GOLD" },
                    { new Guid("74e20fea-171f-4d34-9285-40298c018cca"), "aaa01db0-7b27-44a1-92b1-3a44394a740b", "Customer", "CUSTOMER" },
                    { new Guid("77aaaf94-7e33-4e6e-972a-77e4ec793f04"), "2fc2ce57-7a46-4ab5-b157-cf1f399e622c", "Admin", "ADMINISTRATOR" },
                    { new Guid("e72bfdb8-f3d6-46e9-9989-e740583a53bc"), "be371984-7662-4c6b-b071-2bdfe7d9dbfb", "Platinum", "PLATINUM" },
                    { new Guid("fb574bab-813b-4cde-b7e8-c8188a51803e"), "a6b87d2f-20f6-4774-9739-b7bd2966c626", "Basic", "BASIC" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_TvShowId",
                table: "Episodes",
                column: "TvShowId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCategories_CategoryId",
                table: "MovieCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCategories_MovieId",
                table: "MovieCategories",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCats_CastId",
                table: "MovieCats",
                column: "CastId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCats_MovieId",
                table: "MovieCats",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_OTP_ApplicationUserId",
                table: "OTP",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TvShowCasts_CastId",
                table: "TvShowCasts",
                column: "CastId");

            migrationBuilder.CreateIndex(
                name: "IX_TvShowCasts_TvShowId",
                table: "TvShowCasts",
                column: "TvShowId");

            migrationBuilder.CreateIndex(
                name: "IX_TvShowCategories_CategoryId",
                table: "TvShowCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TvShowCategories_TvShowId",
                table: "TvShowCategories",
                column: "TvShowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "MovieCategories");

            migrationBuilder.DropTable(
                name: "MovieCats");

            migrationBuilder.DropTable(
                name: "OTP");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TvShowCasts");

            migrationBuilder.DropTable(
                name: "TvShowCategories");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Casts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TvShows");
        }
    }
}
