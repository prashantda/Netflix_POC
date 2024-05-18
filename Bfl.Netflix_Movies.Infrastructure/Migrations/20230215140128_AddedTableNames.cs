using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bfl.Netflix.Infrastructure.Migrations
{
    public partial class AddedTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieCast_Casts_CastId",
                table: "MovieCast");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCast_Movies_MovieId",
                table: "MovieCast");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCategory_Categories_CategoryId",
                table: "MovieCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCategory_Movies_MovieId",
                table: "MovieCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_TvShowCast_Casts_CastId",
                table: "TvShowCast");

            migrationBuilder.DropForeignKey(
                name: "FK_TvShowCast_TvShows_TvShowId",
                table: "TvShowCast");

            migrationBuilder.DropForeignKey(
                name: "FK_TvShowCategory_Categories_CategoryId",
                table: "TvShowCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_TvShowCategory_TvShows_TvShowId",
                table: "TvShowCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TvShowCategory",
                table: "TvShowCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TvShowCast",
                table: "TvShowCast");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieCategory",
                table: "MovieCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieCast",
                table: "MovieCast");

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("0adfc864-769a-424e-b08f-524036f1880d"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("19a02692-f7d0-45d9-b53a-b3283bc8039c"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("2925f7cd-09a9-45f1-9b12-29a51b20a637"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("33c96c2f-d920-4f59-87c9-14cf5b1ecc11"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("568eaae9-0e95-4475-beea-a3a49082a180"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("58daa48d-5302-481a-ac33-049891595d6f"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("5ee3acc6-772e-4c3e-a027-6a34605786f3"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("65cd194c-4414-4e82-83a9-a3bb44de0864"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("6671700d-4d28-4cb2-9cb0-c5371e03d7da"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("707d485a-283f-4554-85fa-c35f64ca36b3"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("73a840a8-d7a7-4928-9d5f-ff8a3b5d48d4"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("79b44a19-863f-416b-80bc-362e9c970066"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("7d7d7814-7ffe-4bde-b640-93ffbad3212b"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("8809a1db-51d4-43d5-b6af-7d1b99fa2874"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("978307af-ed52-454f-8c86-87c07279f6fd"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("a11d59df-8737-40f2-aed6-ad7ae54ee876"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("a69d9d6f-05d3-4e48-94dc-0f1237f6e549"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("bdc4c25c-287d-45a5-ae1a-8bed5c232e9e"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("bf283a5e-5f96-4816-af5f-cb20c8b3025b"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("c61f9358-f6a3-4b97-88fa-edaaecce7314"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("cde4e5fd-e046-46ea-9f55-0beb0fc9c155"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("cfe44e86-84b3-45b3-b2fa-74c79ead50d6"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("d0ac0a98-952e-4d4b-abd6-7de44d592313"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("f05aa73e-2479-4353-8e96-864e2d8a8218"));

            migrationBuilder.RenameTable(
                name: "TvShowCategory",
                newName: "TvShowCategories");

            migrationBuilder.RenameTable(
                name: "TvShowCast",
                newName: "TvShowCasts");

            migrationBuilder.RenameTable(
                name: "MovieCategory",
                newName: "MovieCategories");

            migrationBuilder.RenameTable(
                name: "MovieCast",
                newName: "MovieCats");

            migrationBuilder.RenameIndex(
                name: "IX_TvShowCategory_TvShowId",
                table: "TvShowCategories",
                newName: "IX_TvShowCategories_TvShowId");

            migrationBuilder.RenameIndex(
                name: "IX_TvShowCategory_CategoryId",
                table: "TvShowCategories",
                newName: "IX_TvShowCategories_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_TvShowCast_TvShowId",
                table: "TvShowCasts",
                newName: "IX_TvShowCasts_TvShowId");

            migrationBuilder.RenameIndex(
                name: "IX_TvShowCast_CastId",
                table: "TvShowCasts",
                newName: "IX_TvShowCasts_CastId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieCategory_MovieId",
                table: "MovieCategories",
                newName: "IX_MovieCategories_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieCategory_CategoryId",
                table: "MovieCategories",
                newName: "IX_MovieCategories_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieCast_MovieId",
                table: "MovieCats",
                newName: "IX_MovieCats_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieCast_CastId",
                table: "MovieCats",
                newName: "IX_MovieCats_CastId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TvShowCategories",
                table: "TvShowCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TvShowCasts",
                table: "TvShowCasts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieCategories",
                table: "MovieCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieCats",
                table: "MovieCats",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "CastId", "CastName" },
                values: new object[,]
                {
                    { new Guid("0f83f70f-6d89-42f3-953f-5ea5729be362"), "Sai Pallavi" },
                    { new Guid("1b29488f-e330-42b9-9b61-78121f9c0230"), "Tapasi Pannu" },
                    { new Guid("200d1941-a014-4179-afcc-bf15bf0a17ed"), "Madhuri Dixit" },
                    { new Guid("27eafb12-057a-4d7f-8181-320ac73a8531"), "Madhubala" },
                    { new Guid("4301810d-ecce-4e5a-be0d-dcd1106f0fc3"), "Amjad Khan" },
                    { new Guid("57632fe9-017d-41c4-8d4e-28571dbd8d87"), "Akshaye Khanna" },
                    { new Guid("5da44770-40ce-450b-b3df-0255ddb9a299"), "Aliya Bhatt" },
                    { new Guid("66f46881-e918-42a4-8dce-803ca8e5b210"), "Shradhaa Kapoor" },
                    { new Guid("67461f57-a5d8-459c-a90c-4da75d0890a7"), "Deepika Padukone" },
                    { new Guid("6c1b7706-a0b6-4b2d-951c-18144e5c5386"), "Tabu" },
                    { new Guid("72474143-14a5-4727-9ecc-e87bf7a32d9e"), "Ajay Devgn" },
                    { new Guid("7ad3d36b-58c5-416d-a34e-c1f5460feb31"), "Ranvir Kapoor" },
                    { new Guid("8cf650c8-77fc-45bc-acb4-0a306923a5e9"), "Rajkummar Rao" },
                    { new Guid("8e6f2587-5183-4baf-9d44-39bc0b6f67da"), "Anushka Shetty" },
                    { new Guid("9245e61d-20cf-4fee-aaae-d261182f8f69"), "Aamir Khan" },
                    { new Guid("989efc3e-aab9-489c-813e-e5a0bee7b754"), "Amitabh Bachchan" },
                    { new Guid("a02815a4-0f1b-4e43-89fa-cb231ad8ed11"), "Amol Palekar" },
                    { new Guid("a6e6fae2-51d8-4c54-92f9-713917f823b7"), "ABC" },
                    { new Guid("a9b82b2f-d28b-46bb-a86b-fd0828636751"), "Ayushmann Khurrana" },
                    { new Guid("ad529778-2e1c-4b2d-a9bf-10d8cc1f0791"), "Sushant Sing Rajpoot" },
                    { new Guid("d39b6791-1330-465f-99b5-3a537c1b9758"), "Akshay Kumar" },
                    { new Guid("d9b15da5-7058-4474-ae67-766d462785b3"), "Kiaara Adavani" },
                    { new Guid("e62fe11d-52d0-4a25-8505-f9a4c84a3cee"), "Anil Kapoor" },
                    { new Guid("fd68d09c-29bc-4e97-909a-2c5360ddf582"), "Samantha Prabhu" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCategories_Categories_CategoryId",
                table: "MovieCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCategories_Movies_MovieId",
                table: "MovieCategories",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCats_Casts_CastId",
                table: "MovieCats",
                column: "CastId",
                principalTable: "Casts",
                principalColumn: "CastId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCats_Movies_MovieId",
                table: "MovieCats",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvShowCasts_Casts_CastId",
                table: "TvShowCasts",
                column: "CastId",
                principalTable: "Casts",
                principalColumn: "CastId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvShowCasts_TvShows_TvShowId",
                table: "TvShowCasts",
                column: "TvShowId",
                principalTable: "TvShows",
                principalColumn: "TvShowId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvShowCategories_Categories_CategoryId",
                table: "TvShowCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvShowCategories_TvShows_TvShowId",
                table: "TvShowCategories",
                column: "TvShowId",
                principalTable: "TvShows",
                principalColumn: "TvShowId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieCategories_Categories_CategoryId",
                table: "MovieCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCategories_Movies_MovieId",
                table: "MovieCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCats_Casts_CastId",
                table: "MovieCats");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCats_Movies_MovieId",
                table: "MovieCats");

            migrationBuilder.DropForeignKey(
                name: "FK_TvShowCasts_Casts_CastId",
                table: "TvShowCasts");

            migrationBuilder.DropForeignKey(
                name: "FK_TvShowCasts_TvShows_TvShowId",
                table: "TvShowCasts");

            migrationBuilder.DropForeignKey(
                name: "FK_TvShowCategories_Categories_CategoryId",
                table: "TvShowCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_TvShowCategories_TvShows_TvShowId",
                table: "TvShowCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TvShowCategories",
                table: "TvShowCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TvShowCasts",
                table: "TvShowCasts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieCats",
                table: "MovieCats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieCategories",
                table: "MovieCategories");

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("0f83f70f-6d89-42f3-953f-5ea5729be362"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("1b29488f-e330-42b9-9b61-78121f9c0230"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("200d1941-a014-4179-afcc-bf15bf0a17ed"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("27eafb12-057a-4d7f-8181-320ac73a8531"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("4301810d-ecce-4e5a-be0d-dcd1106f0fc3"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("57632fe9-017d-41c4-8d4e-28571dbd8d87"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("5da44770-40ce-450b-b3df-0255ddb9a299"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("66f46881-e918-42a4-8dce-803ca8e5b210"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("67461f57-a5d8-459c-a90c-4da75d0890a7"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("6c1b7706-a0b6-4b2d-951c-18144e5c5386"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("72474143-14a5-4727-9ecc-e87bf7a32d9e"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("7ad3d36b-58c5-416d-a34e-c1f5460feb31"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("8cf650c8-77fc-45bc-acb4-0a306923a5e9"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("8e6f2587-5183-4baf-9d44-39bc0b6f67da"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("9245e61d-20cf-4fee-aaae-d261182f8f69"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("989efc3e-aab9-489c-813e-e5a0bee7b754"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("a02815a4-0f1b-4e43-89fa-cb231ad8ed11"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("a6e6fae2-51d8-4c54-92f9-713917f823b7"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("a9b82b2f-d28b-46bb-a86b-fd0828636751"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("ad529778-2e1c-4b2d-a9bf-10d8cc1f0791"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("d39b6791-1330-465f-99b5-3a537c1b9758"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("d9b15da5-7058-4474-ae67-766d462785b3"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("e62fe11d-52d0-4a25-8505-f9a4c84a3cee"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("fd68d09c-29bc-4e97-909a-2c5360ddf582"));

            migrationBuilder.RenameTable(
                name: "TvShowCategories",
                newName: "TvShowCategory");

            migrationBuilder.RenameTable(
                name: "TvShowCasts",
                newName: "TvShowCast");

            migrationBuilder.RenameTable(
                name: "MovieCats",
                newName: "MovieCast");

            migrationBuilder.RenameTable(
                name: "MovieCategories",
                newName: "MovieCategory");

            migrationBuilder.RenameIndex(
                name: "IX_TvShowCategories_TvShowId",
                table: "TvShowCategory",
                newName: "IX_TvShowCategory_TvShowId");

            migrationBuilder.RenameIndex(
                name: "IX_TvShowCategories_CategoryId",
                table: "TvShowCategory",
                newName: "IX_TvShowCategory_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_TvShowCasts_TvShowId",
                table: "TvShowCast",
                newName: "IX_TvShowCast_TvShowId");

            migrationBuilder.RenameIndex(
                name: "IX_TvShowCasts_CastId",
                table: "TvShowCast",
                newName: "IX_TvShowCast_CastId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieCats_MovieId",
                table: "MovieCast",
                newName: "IX_MovieCast_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieCats_CastId",
                table: "MovieCast",
                newName: "IX_MovieCast_CastId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieCategories_MovieId",
                table: "MovieCategory",
                newName: "IX_MovieCategory_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieCategories_CategoryId",
                table: "MovieCategory",
                newName: "IX_MovieCategory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TvShowCategory",
                table: "TvShowCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TvShowCast",
                table: "TvShowCast",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieCast",
                table: "MovieCast",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieCategory",
                table: "MovieCategory",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "CastId", "CastName" },
                values: new object[,]
                {
                    { new Guid("0adfc864-769a-424e-b08f-524036f1880d"), "Ranvir Kapoor" },
                    { new Guid("19a02692-f7d0-45d9-b53a-b3283bc8039c"), "Kiaara Adavani" },
                    { new Guid("2925f7cd-09a9-45f1-9b12-29a51b20a637"), "Amol Palekar" },
                    { new Guid("33c96c2f-d920-4f59-87c9-14cf5b1ecc11"), "Madhuri Dixit" },
                    { new Guid("568eaae9-0e95-4475-beea-a3a49082a180"), "Ajay Devgn" },
                    { new Guid("58daa48d-5302-481a-ac33-049891595d6f"), "Tabu" },
                    { new Guid("5ee3acc6-772e-4c3e-a027-6a34605786f3"), "Akshaye Khanna" },
                    { new Guid("65cd194c-4414-4e82-83a9-a3bb44de0864"), "Tapasi Pannu" },
                    { new Guid("6671700d-4d28-4cb2-9cb0-c5371e03d7da"), "Sushant Sing Rajpoot" },
                    { new Guid("707d485a-283f-4554-85fa-c35f64ca36b3"), "Ayushmann Khurrana" },
                    { new Guid("73a840a8-d7a7-4928-9d5f-ff8a3b5d48d4"), "ABC" },
                    { new Guid("79b44a19-863f-416b-80bc-362e9c970066"), "Amitabh Bachchan" },
                    { new Guid("7d7d7814-7ffe-4bde-b640-93ffbad3212b"), "Aamir Khan" },
                    { new Guid("8809a1db-51d4-43d5-b6af-7d1b99fa2874"), "Anushka Shetty" },
                    { new Guid("978307af-ed52-454f-8c86-87c07279f6fd"), "Amjad Khan" },
                    { new Guid("a11d59df-8737-40f2-aed6-ad7ae54ee876"), "Anil Kapoor" },
                    { new Guid("a69d9d6f-05d3-4e48-94dc-0f1237f6e549"), "Samantha Prabhu" },
                    { new Guid("bdc4c25c-287d-45a5-ae1a-8bed5c232e9e"), "Madhubala" },
                    { new Guid("bf283a5e-5f96-4816-af5f-cb20c8b3025b"), "Shradhaa Kapoor" },
                    { new Guid("c61f9358-f6a3-4b97-88fa-edaaecce7314"), "Akshay Kumar" },
                    { new Guid("cde4e5fd-e046-46ea-9f55-0beb0fc9c155"), "Sai Pallavi" },
                    { new Guid("cfe44e86-84b3-45b3-b2fa-74c79ead50d6"), "Deepika Padukone" },
                    { new Guid("d0ac0a98-952e-4d4b-abd6-7de44d592313"), "Rajkummar Rao" },
                    { new Guid("f05aa73e-2479-4353-8e96-864e2d8a8218"), "Aliya Bhatt" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCast_Casts_CastId",
                table: "MovieCast",
                column: "CastId",
                principalTable: "Casts",
                principalColumn: "CastId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCast_Movies_MovieId",
                table: "MovieCast",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCategory_Categories_CategoryId",
                table: "MovieCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCategory_Movies_MovieId",
                table: "MovieCategory",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvShowCast_Casts_CastId",
                table: "TvShowCast",
                column: "CastId",
                principalTable: "Casts",
                principalColumn: "CastId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvShowCast_TvShows_TvShowId",
                table: "TvShowCast",
                column: "TvShowId",
                principalTable: "TvShows",
                principalColumn: "TvShowId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvShowCategory_Categories_CategoryId",
                table: "TvShowCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvShowCategory_TvShows_TvShowId",
                table: "TvShowCategory",
                column: "TvShowId",
                principalTable: "TvShows",
                principalColumn: "TvShowId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
