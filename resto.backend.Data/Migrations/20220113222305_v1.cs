using Microsoft.EntityFrameworkCore.Migrations;

namespace resto.backend.Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<string>(type: "TEXT", nullable: true),
                    Time = table.Column<string>(type: "TEXT", nullable: true),
                    UrlPhoto = table.Column<string>(type: "TEXT", nullable: true),
                    UrlLogo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Latitude = table.Column<double>(type: "REAL", nullable: false),
                    Longitude = table.Column<double>(type: "REAL", nullable: false),
                    UrlPhoto = table.Column<string>(type: "TEXT", nullable: true),
                    UrlLogo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuRestaurant",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RestaurantId = table.Column<long>(type: "INTEGER", nullable: false),
                    MenuId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRestaurant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuRestaurant_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuRestaurant_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "Time", "UrlLogo", "UrlPhoto" },
                values: new object[] { 1L, "Volaille", "Escalopes de dinde aux oignons confits extra fines", "Plat Escaloppe Panée", "12", "20", "https://cdn-icons.flaticon.com/png/512/737/premium/737956.png?token=exp=1642110601~hmac=0efd6e58af8dbc8f84751bf90f04732a", "https://sf1.viepratique.fr/wp-content/uploads/sites/2/2015/04/Filet-de-dinde-aux-oignons-sauce-au-yaourt.jpg" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "Time", "UrlLogo", "UrlPhoto" },
                values: new object[] { 11L, "Poissons", "Grillade de poissons de saison bien garnies avec salade verte et frites", "Grillade de Poissons", "22", "25", "https://cdn-icons.flaticon.com/png/512/783/premium/783043.png?token=exp=1642110950~hmac=737a2ec2f23d244f442bf8391867dfb4", "http://restodino.com/wp-content/uploads/2020/04/Grillade-poisson-pour-cest-bon.jpg" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "Time", "UrlLogo", "UrlPhoto" },
                values: new object[] { 9L, "Sandwitch", "Sandwitch Tunisien aux thon et olives verts", "Sandwitch 3arbi", "18", "15", "https://cdn-icons-png.flaticon.com/512/3248/3248708.png", "https://cuisine.nessma.tv/uploads/7/2020-06/c7d07b8fa720d596ed458e9c2399f3ba.png" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "Time", "UrlLogo", "UrlPhoto" },
                values: new object[] { 8L, "Pizza", "Pizza aux fruits de mer et pesto de persil-parmesan-citron", "Pizza fruit de mer", "18", "15", "https://cdn-icons.flaticon.com/png/512/3511/premium/3511307.png?token=exp=1642109103~hmac=f4af5385f7c8a3011dc012dde9bcd9f3", "https://cuisine.nessma.tv/uploads/7/2020-11/747596a9f2f164eda4a451eef69669a0.jpg" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "Time", "UrlLogo", "UrlPhoto" },
                values: new object[] { 7L, "Pizza", "Pizza au feu du bois bien garnies avec la viande de veau et les meilleurs fromages", "Pizza Viande Hachée", "12", "9", "https://cdn-icons.flaticon.com/png/512/3511/premium/3511307.png?token=exp=1642109103~hmac=f4af5385f7c8a3011dc012dde9bcd9f3", "https://img.cuisineaz.com/660x660/2016-01-30/i90037-pizza-steaks-haches-tomates-et-mozzarella.jpg" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "Time", "UrlLogo", "UrlPhoto" },
                values: new object[] { 10L, "Grillade", "Brochette de viande d'angeau avec garniture et salades variées", "Brochette Viande d'agneau", "14", "20", "https://cdn-icons.flaticon.com/png/512/1791/premium/1791711.png?token=exp=1642110026~hmac=08246dcf7439648d5676a3ef2c276c64", "https://cuisine.nessma.tv/uploads/1/2019-07/4701dfb2dbe5c7e3086187b1f738d8c2.jpg" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "Time", "UrlLogo", "UrlPhoto" },
                values: new object[] { 5L, "Sandiwtch", "sandwichs Makloub chawarma avec garniture complète et généreuse", "Sandwitch Makloub Chawarma", "6", "8", "https://cdn-icons-png.flaticon.com/512/3248/3248708.png", "https://64.media.tumblr.com/957e7090276fcabd8556ea49bdf8e70b/ff24b503f365020e-b7/s1280x1920/6a0604a638d91e89048d79dd8c84267190997dbc.jpg" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "Time", "UrlLogo", "UrlPhoto" },
                values: new object[] { 4L, "Pasta", "Ce délicieux plat est fait avec un mélange de fruits de mer cuits dans une sauce tomate aux oignons, ail, coriandre, cumin, rocou et poudre de chili ou (harissa)", "Spaghetti aux Fruits de Mer", "18", "25", "https://cdn-icons-png.flaticon.com/512/3480/3480618.png", "https://www.demotivateur.fr/images-buzz/cover/183468931257aa0017f2040_Sans-titre-19.jpg" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "Time", "UrlLogo", "UrlPhoto" },
                values: new object[] { 3L, "Enfant", "Pizza Napolitaine + Plat frites + boisson", "Menu kidz", "10", "15", "https://cdn-icons.flaticon.com/png/512/2880/premium/2880484.png?token=exp=1642110670~hmac=fc13d60e943c62aff1aab81721d1a1f4", "https://www.atelierdeschefs.com/media/recette-e23069-pizza-napolitaine.jpg" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "Time", "UrlLogo", "UrlPhoto" },
                values: new object[] { 2L, "Sandwich", "Délicieux tacos au poulet parfumés au curcuma et une pincée de curry", "Sandwich Tacos", "7", "10", "https://cdn-icons-png.flaticon.com/512/3248/3248708.png", "https://fac.img.pmdstatic.net/fit/http.3A.2F.2Fprd2-bone-image.2Es3-website-eu-west-1.2Eamazonaws.2Ecom.2Ffac.2F2019.2F01.2F03.2F9bdc34bd-6233-45cb-986e-df99523545f0.2Ejpeg/850x478/quality/90/crop-from/center/tacos-ces-sandwichs-hypercaloriques-sont-il-pires-que-des-burgers.jpeg" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "Time", "UrlLogo", "UrlPhoto" },
                values: new object[] { 6L, "Tunisien", "Composée d'olives, de thon, d'œufs cuits durs, de tomates, de piments verts et sans oublier l'huile d'olive vierge Tunisienne.", "Salade Tunisienne", "6", "10", "https://cdn-icons.flaticon.com/png/512/4855/premium/4855834.png?token=exp=1642110722~hmac=436a38f5d0107208a26951d7564df256", "https://media.eggs.ca/assets/RecipePhotos/_resampled/FillWyIxMjgwIiwiNzIwIl0/Nicoise-Salad-022-LR.jpg" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "UrlLogo", "UrlPhoto" },
                values: new object[] { 8L, "La voile blanche restaurants à Sfax - Fruits de mer & Poisson Méditerranéenne Tunisienne", 34.753014480384401, 10.757744442094603, "La voile blanche", "https://scontent.ftun10-1.fna.fbcdn.net/v/t31.18172-8/16143476_1180660678696363_7890264209456336271_o.jpg?_nc_cat=106&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=6RQwaPB25VcAX9rRKQW&_nc_ht=scontent.ftun10-1.fna&oh=00_AT_Fwq1nsclgt7cfMQ2Jc4H7zottlYq-PW3Mh6RQWpPrxQ&oe=62061A61", "https://scontent.ftun10-1.fna.fbcdn.net/v/t1.6435-9/s960x960/122225003_3328847167211026_2998804788314153198_n.jpg?_nc_cat=102&ccb=1-5&_nc_sid=8bfeb9&_nc_ohc=G8T1hRmJr8QAX9wtvvd&_nc_ht=scontent.ftun10-1.fna&oh=00_AT-td6rn0hE4dDlxlzTarAd-969xnnKVQ5nwhKgYDUEwFw&oe=6204540B" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "UrlLogo", "UrlPhoto" },
                values: new object[] { 1L, "Kechmech Spécialité sandwich italien et tunisien ", 34.742112661488967, 10.756184298471036, "Kechmech", "https://img.restaurantguru.com/r1c8-Kechmech-logo.jpg", "https://www.villedesfax.com/wp-content/uploads/2019/04/1-2.jpg" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "UrlLogo", "UrlPhoto" },
                values: new object[] { 2L, "TONTON spécialisée Restaurants, Restauration Rapide - Fast-foods - Rotisseries - Sandwicheries.", 34.742331830934425, 10.754495972724662, "TonTon", "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642073508/Flutter%2A/download_cfbh7c.jpg", "https://allrest-space.fra1.digitaloceanspaces.com/adverts/restaurants/tonton-3/tonton.jpeg" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "UrlLogo", "UrlPhoto" },
                values: new object[] { 3L, "Papillon spécialisée hamburgers, pizzas, poulets et sandwichs - Fast-foods.", 34.766305492786053, 10.74422188627223, "Papillon", "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642107567/Flutter%2A/download_ocqgvv.jpg", "https://10619-2.s.cdn12.com/rests/original/312_508908254.jpg" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "UrlLogo", "UrlPhoto" },
                values: new object[] { 4L, "CUISINES Tunisienne, Steakhouse, Méditerranéenne, Barbecue/Grillades.", 34.736310266430806, 10.762069369081546, "Safoud Abid", "https://scontent.ftun10-1.fna.fbcdn.net/v/t1.18169-9/17862618_1397221710340475_6119642009369072306_n.jpg?_nc_cat=103&ccb=1-5&_nc_sid=730e14&_nc_ohc=IMahhA0T8NMAX-TJB4h&_nc_oc=AQm0Uj-eT753bUqeMH7OWEM-G1DSMBrYRwWqSaPD70DaSVocc5VmHW8ZrIBYwmsRnt4&_nc_ht=scontent.ftun10-1.fna&oh=00_AT_ye4wGOB_fppcvi0roaopTcDarmwS-VYvCqQH_BldZHw&oe=6205B7B3", "https://tunisie.co/uploads/images/content/safoud-050816-3.jpg" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "UrlLogo", "UrlPhoto" },
                values: new object[] { 5L, "L'Agora Resto restaurants à Sfax - Italienne Méditerranéenne Tunisienne.", 34.757921884394804, 10.733915869081951, "L'Agora Resto", "https://scontent.ftun16-1.fna.fbcdn.net/v/t1.6435-9/54222310_836384513363419_4827507691259691008_n.png?_nc_cat=104&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=iFCzV15PALkAX_gc-vR&_nc_ht=scontent.ftun16-1.fna&oh=00_AT-lribzULeNpiVZ5D4wE_SNV0pm2q7SGJ27nu_excsa8Q&oe=62053AFC", "https://lagora-resto.tn/wp-content/uploads/2019/04/20180316_145704-300x250.jpg" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "UrlLogo", "UrlPhoto" },
                values: new object[] { 6L, "Borj dhiafa restaurants à Sfax - Française Internationale Méditerranéenne.", 34.725339319152624, 10.723978013258671, "Borj dhiafa", "https://www.hotelborjdhiafa.com//wp-content/gallery/slide_index/slide1.jpg", "https://lh5.googleusercontent.com/p/AF1QipOMmKu6XI9Ma10yrvet6KJjv4NHciX_hgT3I35h=w253-h168-k-no" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "UrlLogo", "UrlPhoto" },
                values: new object[] { 7L, "Restaurant Baghdad restaurants à Sfax - Fruits de mer & Poisson Méditerranéenne Tunisienne", 34.73359819271915, 10.76088911141056, "Restaurant Baghdad", "https://scontent.ftun16-1.fna.fbcdn.net/v/t31.18172-8/11416405_847062178739642_3869777224013111764_o.jpg?_nc_cat=100&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=WizAnxIGY5AAX9kE3F9&_nc_ht=scontent.ftun16-1.fna&oh=00_AT_2PxY0mHjjorfJGxUjJLLzA8SoEbPEinWwlhVW_0tK2g&oe=6206CBDE", "https://img.restaurantguru.com/rb9b-Restaurant-Baghdad-interior.jpg" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "UrlLogo", "UrlPhoto" },
                values: new object[] { 9L, "Farm Slice Pizza restaurant à Sfax€€-€€€AméricainePizza", 34.767470149514516, 10.747181782575737, "Farm Slice Pizza", "https://scontent.ftun10-1.fna.fbcdn.net/v/t39.30808-6/263979316_2388023538006788_2725964595273535910_n.png?_nc_cat=109&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=bxBqiH2mcOcAX8xOzwn&_nc_ht=scontent.ftun10-1.fna&oh=00_AT8umHHQDEgRVKWBe55jnXxvn7g_nn7_2knCKIlYcG-Ycg&oe=61E5262B", "https://scontent.ftun10-1.fna.fbcdn.net/v/t39.30808-6/271543337_2413134665495675_8425052987987141585_n.jpg?_nc_cat=110&ccb=1-5&_nc_sid=a26aad&_nc_ohc=S9SDTAeSlKQAX-NPuwh&_nc_ht=scontent.ftun10-1.fna&oh=00_AT-kAOObvRa9Yv2PN4TqhwiAkxZuPevgE7H0bleAEzjaqQ&oe=61E60848" });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 1L, 1L, 1L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 23L, 8L, 9L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 22L, 6L, 8L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 21L, 4L, 8L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 20L, 8L, 8L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 19L, 11L, 8L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 18L, 8L, 7L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 17L, 4L, 7L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 16L, 4L, 6L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 15L, 11L, 6L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 14L, 1L, 5L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 24L, 7L, 9L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 13L, 4L, 5L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 11L, 8L, 5L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 10L, 10L, 4L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 9L, 7L, 3L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 8L, 3L, 3L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 7L, 2L, 3L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 6L, 1L, 3L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 5L, 4L, 2L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 4L, 2L, 2L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 3L, 3L, 1L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 2L, 2L, 1L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 12L, 7L, 5L });

            migrationBuilder.InsertData(
                table: "MenuRestaurant",
                columns: new[] { "Id", "MenuId", "RestaurantId" },
                values: new object[] { 25L, 5L, 9L });

            migrationBuilder.CreateIndex(
                name: "IX_MenuRestaurant_MenuId",
                table: "MenuRestaurant",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRestaurant_RestaurantId",
                table: "MenuRestaurant",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuRestaurant");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Restaurant");
        }
    }
}
