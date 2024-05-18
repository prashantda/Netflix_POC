using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bfl.Netflix.Infrastructure.Migrations
{
    public partial class BaseAddedInMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("0432031c-79dd-49e0-a3f7-59221fef55a7"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("107ca531-68f0-4b34-a6ff-efd0d12d0110"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("1268244c-fb2c-4ee6-b25c-e89e08e23950"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("15b0a214-e36f-4101-b911-83e16a9dfcdd"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("195f3652-c390-4705-9f75-d88ce27dacaf"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("207cc525-5a71-4a2c-b317-f757d8a49753"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("23cee9a2-b0e5-44ad-892c-9c3184322ab0"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("2af3e4e3-32c1-4b5d-8555-7aaf7054c13e"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("479f8f66-2cb5-499e-8509-daf98918bec8"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("48114c9e-e646-4dd7-98ae-06e2d0f82829"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("4c774386-0b7f-432e-8a6f-44f2f84aac73"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("5404c987-6146-453c-9611-5f85119b74c7"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("57c94d5c-55bd-4452-88d6-6ea9b05123ec"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("5abbb589-ed12-42aa-b6a4-78b32d562a14"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("64e9cafa-a883-4719-abff-f6c530ec9ede"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("72eba14e-4cb5-4862-8c79-f844966e39d3"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("8c2c6d0d-6063-4b11-ac65-bbdcb3e58719"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("8c5cf78e-58c3-437a-9bbf-0b446a419f51"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("95cad04c-bb57-40e3-8ed8-6fd1ac3e81ce"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("98f024b8-3b31-43c7-b6f9-17a486e88b3d"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("a5ff9ba3-b615-43d4-af0e-5a13d2605f81"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("c5435d6a-eb1c-43b5-8eae-b0f4a0f0661a"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("f6fa91d4-777c-439f-8350-da1b15938c98"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("f70a5658-9d2c-4746-a22c-98322c14e16c"));

            migrationBuilder.AddColumn<string>(
                name: "CreatorName",
                table: "Movies",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Movies",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Movies",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Movies",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TrailerPath",
                table: "Movies",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VideoPath",
                table: "Movies",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "CreatorName",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "TrailerPath",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "VideoPath",
                table: "Movies");

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
        }
    }
}
