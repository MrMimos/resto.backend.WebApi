using Microsoft.EntityFrameworkCore.Migrations;

namespace resto.backend.Data.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UrlPhoto",
                value: "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353544/Flutter%2A/183468931257aa0017f2040_Sans-titre-19_usi3bg.webp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UrlPhoto",
                value: "https://www.demotivateur.fr/images-buzz/cover/183468931257aa0017f2040_Sans-titre-19.jpg");
        }
    }
}
