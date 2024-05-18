using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bfl.Netflix.Infrastructure.Migrations
{
    public partial class sp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("0e5a75a5-d922-4b9e-96f5-9867a570f245"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("15945d5e-6931-4a8c-8407-fd9a0f28b192"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("23a7a28f-a6c2-4ca9-8641-4b7d3165f174"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("2bc22bea-ffbe-44a7-bc73-71399f7d5329"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("2c8829b4-2556-4e31-890e-14264d861c17"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("3010134f-c645-479c-99ea-bf0152313e74"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("35f3cbc2-4e2b-49fe-850a-a7d7d7ade9c4"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("4267c6f8-364b-48ce-8fbf-8d8a33725c3a"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("481efb81-01cd-4a03-a4b4-e51720b0a741"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("48b8d06c-c6ea-4f24-949a-8adf9949a792"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("4d12998d-a864-4afc-a24e-e27ab6d7a809"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("63a4433f-49db-4879-b8fd-e0bfb2848e01"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("6c052e74-e95c-441e-8436-e9299379f22f"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("72bedf60-c2c8-453f-bbc8-29fac271fb52"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("7acfcd71-4b19-478d-9e89-4282f66a636a"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("7fae8cd6-db37-4a5b-8871-831b68363eb0"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("862f0cf4-f949-415d-88dd-46785f80d03d"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("8bff0716-a2e3-4501-9df7-58cc1c8ac3e7"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("8ef8c392-ca9c-4af2-b7af-508fc832c3d6"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("b34e78fe-845d-4ad3-93eb-dd7158857b7f"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("c05ead16-6945-4994-803b-487eaa486c48"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("c32280ab-9f3d-4d4f-a8f4-552f159312e8"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("e5a7344a-7c0b-47f7-8e04-6df850835467"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: new Guid("e62f0df3-f3b3-4aa8-a70c-1733b438ba64"));

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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0313b580-93d9-4677-b4f2-5924509b63b0"),
                column: "ConcurrencyStamp",
                value: "2e95b8e1-3e50-4748-87c9-7b0f5e61b6df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("74e20fea-171f-4d34-9285-40298c018cca"),
                column: "ConcurrencyStamp",
                value: "aaa01db0-7b27-44a1-92b1-3a44394a740b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77aaaf94-7e33-4e6e-972a-77e4ec793f04"),
                column: "ConcurrencyStamp",
                value: "2fc2ce57-7a46-4ab5-b157-cf1f399e622c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e72bfdb8-f3d6-46e9-9989-e740583a53bc"),
                column: "ConcurrencyStamp",
                value: "be371984-7662-4c6b-b071-2bdfe7d9dbfb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fb574bab-813b-4cde-b7e8-c8188a51803e"),
                column: "ConcurrencyStamp",
                value: "a6b87d2f-20f6-4774-9739-b7bd2966c626");
        }
    }
}
