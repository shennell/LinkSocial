using Microsoft.EntityFrameworkCore.Migrations;

namespace LinkSocial.Server.Data.Migrations
{
    public partial class Settings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PageSettings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProfilePictureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntroText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HideProfilePic = table.Column<bool>(type: "bit", nullable: false),
                    HideTitle = table.Column<bool>(type: "bit", nullable: false),
                    HideIntroText = table.Column<bool>(type: "bit", nullable: false),
                    Theme = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageSettings", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PageSettings_PageName",
                table: "PageSettings",
                column: "PageName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PageSettings");
        }
    }
}
