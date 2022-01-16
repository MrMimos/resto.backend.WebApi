using Microsoft.EntityFrameworkCore.Migrations;

namespace resto.backend.Data.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UrlPhoto",
                value: "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353266/Flutter%2A/Filet-de-dinde-aux-oignons-sauce-au-yaourt_mhe6rj.jpg");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UrlPhoto",
                value: "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353265/Flutter%2A/recette-e23069-pizza-napolitaine_b9hamn.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UrlPhoto",
                value: "https://sf1.viepratique.fr/wp-content/uploads/sites/2/2015/04/Filet-de-dinde-aux-oignons-sauce-au-yaourt.jpg");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UrlPhoto",
                value: "https://www.atelierdeschefs.com/media/recette-e23069-pizza-napolitaine.jpg");
        }
    }
}
