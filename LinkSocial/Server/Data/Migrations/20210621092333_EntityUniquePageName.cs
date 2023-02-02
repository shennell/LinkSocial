using Microsoft.EntityFrameworkCore.Migrations;

namespace LinkSocial.Server.Data.Migrations
{
    public partial class EntityUniquePageName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PageName",
                table: "AspNetUsers",
                column: "PageName",
                unique: true,
                filter: "[PageName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PageName",
                table: "AspNetUsers");
        }
    }
}
