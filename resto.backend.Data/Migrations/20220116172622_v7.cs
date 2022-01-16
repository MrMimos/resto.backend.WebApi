using Microsoft.EntityFrameworkCore.Migrations;

namespace resto.backend.Data.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UrlPhoto",
                value: "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353713/Flutter%2A/i90037-pizza-steaks-haches-tomates-et-mozzarella_bbbvpi.jpg");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UrlPhoto",
                value: "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353871/Flutter%2A/747596a9f2f164eda4a451eef69669a0_mmiaky.jpg");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UrlPhoto",
                value: "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353753/Flutter%2A/4701dfb2dbe5c7e3086187b1f738d8c2_djpaei.jpg");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 11L,
                column: "UrlPhoto",
                value: "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353934/Flutter%2A/Grillade-poisson-pour-cest-bon_qo2ngl.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UrlPhoto",
                value: "https://img.cuisineaz.com/660x660/2016-01-30/i90037-pizza-steaks-haches-tomates-et-mozzarella.jpg");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UrlPhoto",
                value: "https://cuisine.nessma.tv/uploads/7/2020-11/747596a9f2f164eda4a451eef69669a0.jpg");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UrlPhoto",
                value: "https://cuisine.nessma.tv/uploads/1/2019-07/4701dfb2dbe5c7e3086187b1f738d8c2.jpg");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 11L,
                column: "UrlPhoto",
                value: "http://restodino.com/wp-content/uploads/2020/04/Grillade-poisson-pour-cest-bon.jpg");
        }
    }
}
