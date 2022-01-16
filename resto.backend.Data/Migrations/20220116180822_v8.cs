using Microsoft.EntityFrameworkCore.Migrations;

namespace resto.backend.Data.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UrlPhoto",
                value: "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642354061/Flutter%2A/Nicoise-Salad-022-LR_w8futd.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UrlPhoto",
                value: "https://media.eggs.ca/assets/RecipePhotos/_resampled/FillWyIxMjgwIiwiNzIwIl0/Nicoise-Salad-022-LR.jpg");
        }
    }
}
