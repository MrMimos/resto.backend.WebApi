using Microsoft.EntityFrameworkCore.Migrations;

namespace resto.backend.Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UrlPhoto",
                value: "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642352966/Flutter%2A/1-2_gxehd6.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UrlPhoto",
                value: "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642352965/Flutter%2A/safoud-050816-3_yq5yqm.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UrlPhoto",
                value: "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642352963/Flutter%2A/20180316_145704-300x250_nvnlz4.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UrlPhoto",
                value: "https://www.villedesfax.com/wp-content/uploads/2019/04/1-2.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UrlPhoto",
                value: "https://tunisie.co/uploads/images/content/safoud-050816-3.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UrlPhoto",
                value: "https://lagora-resto.tn/wp-content/uploads/2019/04/20180316_145704-300x250.jpg");
        }
    }
}
