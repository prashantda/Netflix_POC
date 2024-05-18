using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bfl.Netflix.Infrastructure.Migrations
{
    public partial class Security1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "OTP",
                columns: table => new
                {
                    TempUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OTP = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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

           

            

            migrationBuilder.CreateIndex(
                name: "IX_OTP_ApplicationUserId",
                table: "OTP",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OTP");

            

        }
    }
}
