using resto.backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace resto.backend.Data
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Menu> Menu { get; set; }

        public DbSet<MenuRestaurant> MenuRestaurant { get; set; }


        public IConfiguration Configuration { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

             => optionsBuilder.UseSqlite("Filename=restoDB.db", options =>
             {
                 options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
             });
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                Id = 1,
                Name = "Plat Escaloppe Panée",
                Description = "Escalopes de dinde aux oignons confits extra fines",
                Price = "12",
                Time = "20",
                Category = "Volaille",
                UrlLogo = "https://cdn-icons.flaticon.com/png/512/737/premium/737956.png?token=exp=1642110601~hmac=0efd6e58af8dbc8f84751bf90f04732a",
                UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353266/Flutter%2A/Filet-de-dinde-aux-oignons-sauce-au-yaourt_mhe6rj.jpg"
            }, new Menu
            {
                Id = 2,
                Name = "Sandwich Tacos",
                Description = "Délicieux tacos au poulet parfumés au curcuma et une pincée de curry",
                Price = "7",
                Time = "10",
                Category = "Sandwich",
                UrlLogo = "https://cdn-icons-png.flaticon.com/512/3248/3248708.png",
                UrlPhoto = "https://fac.img.pmdstatic.net/fit/http.3A.2F.2Fprd2-bone-image.2Es3-website-eu-west-1.2Eamazonaws.2Ecom.2Ffac.2F2019.2F01.2F03.2F9bdc34bd-6233-45cb-986e-df99523545f0.2Ejpeg/850x478/quality/90/crop-from/center/tacos-ces-sandwichs-hypercaloriques-sont-il-pires-que-des-burgers.jpeg"
            }, new Menu
            {
                Id = 3,
                Name = "Menu kidz",
                Description = "Pizza Napolitaine + Plat frites + boisson",
                Price = "10",
                Time = "15",
                Category = "Enfant",
                UrlLogo = "https://cdn-icons.flaticon.com/png/512/2880/premium/2880484.png?token=exp=1642110670~hmac=fc13d60e943c62aff1aab81721d1a1f4",
                UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353265/Flutter%2A/recette-e23069-pizza-napolitaine_b9hamn.jpg"
            }, new Menu
            {
                Id = 4,
                Name = "Spaghetti aux Fruits de Mer",
                Description =
                    "Ce délicieux plat est fait avec un mélange de fruits de mer cuits dans une sauce tomate aux oignons, ail, coriandre, cumin, rocou et poudre de chili ou (harissa)",
                Price = "18",
                Time = "25",
                Category = "Pasta",
                UrlLogo = "https://cdn-icons-png.flaticon.com/512/3480/3480618.png",
                UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353544/Flutter%2A/183468931257aa0017f2040_Sans-titre-19_usi3bg.webp"
            }, new Menu
            {
                Id = 5,
                Name = "Sandwitch Makloub Chawarma",
                Description = "sandwichs Makloub chawarma avec garniture complète et généreuse",
                Price = "6",
                Time = "8",
                Category = "Sandiwtch",
                UrlLogo = "https://cdn-icons-png.flaticon.com/512/3248/3248708.png",
                UrlPhoto = "https://64.media.tumblr.com/957e7090276fcabd8556ea49bdf8e70b/ff24b503f365020e-b7/s1280x1920/6a0604a638d91e89048d79dd8c84267190997dbc.jpg"

            }, new Menu
            {
                Id = 6,
                Name = "Salade Tunisienne",
                Description = "Composée d'olives, de thon, d'œufs cuits durs, de tomates, de piments verts et sans oublier l'huile d'olive vierge Tunisienne.",
                Price = "6",
                Time = "10",
                Category = "Tunisien",
                UrlLogo = "https://cdn-icons.flaticon.com/png/512/4855/premium/4855834.png?token=exp=1642110722~hmac=436a38f5d0107208a26951d7564df256",
                UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642354061/Flutter%2A/Nicoise-Salad-022-LR_w8futd.jpg"

            }, new Menu
            {
                Id = 7,
                Name = "Pizza Viande Hachée",
                Description = "Pizza au feu du bois bien garnies avec la viande de veau et les meilleurs fromages",
                Price = "12",
                Time = "9",
                Category = "Pizza",
                UrlLogo = "https://cdn-icons.flaticon.com/png/512/3511/premium/3511307.png?token=exp=1642109103~hmac=f4af5385f7c8a3011dc012dde9bcd9f3",
                UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353713/Flutter%2A/i90037-pizza-steaks-haches-tomates-et-mozzarella_bbbvpi.jpg"

            }, new Menu
            {
                Id = 8,
                Name = "Pizza fruit de mer",
                Description = "Pizza aux fruits de mer et pesto de persil-parmesan-citron",
                Price = "18",
                Time = "15",
                Category = "Pizza",
                UrlLogo = "https://cdn-icons.flaticon.com/png/512/3511/premium/3511307.png?token=exp=1642109103~hmac=f4af5385f7c8a3011dc012dde9bcd9f3",
                UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353871/Flutter%2A/747596a9f2f164eda4a451eef69669a0_mmiaky.jpg"

            }, new Menu
            {
                Id = 9,
                Name = "Sandwitch 3arbi",
                Description = "Sandwitch Tunisien aux thon et olives verts",
                Price = "18",
                Time = "15",
                Category = "Sandwitch",
                UrlLogo = "https://cdn-icons-png.flaticon.com/512/3248/3248708.png",
                UrlPhoto = "https://cuisine.nessma.tv/uploads/7/2020-06/c7d07b8fa720d596ed458e9c2399f3ba.png"

            }, new Menu
            {
                Id = 10,
                Name = "Brochette Viande d'agneau",
                Description = "Brochette de viande d'angeau avec garniture et salades variées",
                Price = "14",
                Time = "20",
                Category = "Grillade",
                UrlLogo = "https://cdn-icons.flaticon.com/png/512/1791/premium/1791711.png?token=exp=1642110026~hmac=08246dcf7439648d5676a3ef2c276c64",
                UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353753/Flutter%2A/4701dfb2dbe5c7e3086187b1f738d8c2_djpaei.jpg"

            }, new Menu
            {
                Id = 11,
                Name = "Grillade de Poissons",
                Description = "Grillade de poissons de saison bien garnies avec salade verte et frites",
                Price = "22",
                Time = "25",
                Category = "Poissons",
                UrlLogo = "https://cdn-icons.flaticon.com/png/512/783/premium/783043.png?token=exp=1642110950~hmac=737a2ec2f23d244f442bf8391867dfb4",
                UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353934/Flutter%2A/Grillade-poisson-pour-cest-bon_qo2ngl.jpg"

            });

            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                Id = 1,
                Name = "Kechmech",
                Description = "Kechmech Spécialité sandwich italien et tunisien ",
                Latitude = 34.74211266148897,
                Longitude = 10.756184298471036,
                UrlLogo = "https://img.restaurantguru.com/r1c8-Kechmech-logo.jpg",
                UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642352966/Flutter%2A/1-2_gxehd6.jpg"
            }, new Restaurant
            {
                Id = 2,
                Name = "TonTon",
                Description = "TONTON spécialisée Restaurants, Restauration Rapide - Fast-foods - Rotisseries - Sandwicheries.",
                Latitude = 34.742331830934425,
                Longitude = 10.754495972724662,
                UrlLogo = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642073508/Flutter%2A/download_cfbh7c.jpg",
                UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642339252/Flutter%2A/tonton_sor8iy.jpg"
            }, new Restaurant
            {
                Id = 3,
                Name = "Papillon",
                Description = "Papillon spécialisée hamburgers, pizzas, poulets et sandwichs - Fast-foods.",
                Latitude = 34.76630549278605,
                Longitude = 10.74422188627223,
                UrlLogo = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642107567/Flutter%2A/download_ocqgvv.jpg",
                UrlPhoto = "https://10619-2.s.cdn12.com/rests/original/312_508908254.jpg"
            }, new Restaurant
            {
                Id = 4,
                Name = "Safoud Abid",
                Description = "CUISINES Tunisienne, Steakhouse, Méditerranéenne, Barbecue/Grillades.",
                Latitude = 34.736310266430806,
                Longitude = 10.762069369081546,
                UrlLogo = "https://scontent.ftun10-1.fna.fbcdn.net/v/t1.18169-9/17862618_1397221710340475_6119642009369072306_n.jpg?_nc_cat=103&ccb=1-5&_nc_sid=730e14&_nc_ohc=IMahhA0T8NMAX-TJB4h&_nc_oc=AQm0Uj-eT753bUqeMH7OWEM-G1DSMBrYRwWqSaPD70DaSVocc5VmHW8ZrIBYwmsRnt4&_nc_ht=scontent.ftun10-1.fna&oh=00_AT_ye4wGOB_fppcvi0roaopTcDarmwS-VYvCqQH_BldZHw&oe=6205B7B3",
                UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642352965/Flutter%2A/safoud-050816-3_yq5yqm.jpg"
            }, new Restaurant
            {
                Id = 5,
                Name = "L'Agora Resto",
                Description = "L'Agora Resto restaurants à Sfax - Italienne Méditerranéenne Tunisienne.",
                Latitude = 34.757921884394804,
                Longitude = 10.733915869081951,
                UrlLogo = "https://scontent.ftun16-1.fna.fbcdn.net/v/t1.6435-9/54222310_836384513363419_4827507691259691008_n.png?_nc_cat=104&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=iFCzV15PALkAX_gc-vR&_nc_ht=scontent.ftun16-1.fna&oh=00_AT-lribzULeNpiVZ5D4wE_SNV0pm2q7SGJ27nu_excsa8Q&oe=62053AFC",
                UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642352963/Flutter%2A/20180316_145704-300x250_nvnlz4.jpg"
            }, new Restaurant
            {
                Id = 6,
                Name = "Borj dhiafa",
                Description = "Borj dhiafa restaurants à Sfax - Française Internationale Méditerranéenne.",
                Latitude = 34.725339319152624,
                Longitude = 10.723978013258671,
                UrlLogo = "https://www.hotelborjdhiafa.com//wp-content/gallery/slide_index/slide1.jpg",
                UrlPhoto = "https://lh5.googleusercontent.com/p/AF1QipOMmKu6XI9Ma10yrvet6KJjv4NHciX_hgT3I35h=w253-h168-k-no"
            }, new Restaurant
            {
                Id = 7,
                Name = "Restaurant Baghdad",
                Description = "Restaurant Baghdad restaurants à Sfax - Fruits de mer & Poisson Méditerranéenne Tunisienne",
                Latitude = 34.73359819271915,
                Longitude = 10.76088911141056,
                UrlLogo = "https://scontent.ftun16-1.fna.fbcdn.net/v/t31.18172-8/11416405_847062178739642_3869777224013111764_o.jpg?_nc_cat=100&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=WizAnxIGY5AAX9kE3F9&_nc_ht=scontent.ftun16-1.fna&oh=00_AT_2PxY0mHjjorfJGxUjJLLzA8SoEbPEinWwlhVW_0tK2g&oe=6206CBDE",
                UrlPhoto = "https://img.restaurantguru.com/rb9b-Restaurant-Baghdad-interior.jpg"
            }, new Restaurant
            {
                Id = 8,
                Name = "La voile blanche",
                Description = "La voile blanche restaurants à Sfax - Fruits de mer & Poisson Méditerranéenne Tunisienne",
                Latitude = 34.7530144803844,
                Longitude = 10.757744442094603,
                UrlLogo = "https://scontent.ftun10-1.fna.fbcdn.net/v/t31.18172-8/16143476_1180660678696363_7890264209456336271_o.jpg?_nc_cat=106&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=6RQwaPB25VcAX9rRKQW&_nc_ht=scontent.ftun10-1.fna&oh=00_AT_Fwq1nsclgt7cfMQ2Jc4H7zottlYq-PW3Mh6RQWpPrxQ&oe=62061A61",
                UrlPhoto = "https://scontent.ftun10-1.fna.fbcdn.net/v/t1.6435-9/s960x960/122225003_3328847167211026_2998804788314153198_n.jpg?_nc_cat=102&ccb=1-5&_nc_sid=8bfeb9&_nc_ohc=G8T1hRmJr8QAX9wtvvd&_nc_ht=scontent.ftun10-1.fna&oh=00_AT-td6rn0hE4dDlxlzTarAd-969xnnKVQ5nwhKgYDUEwFw&oe=6204540B"
            }, new Restaurant
            {
                Id = 9,
                Name = "Farm Slice Pizza",
                Description = "Farm Slice Pizza restaurant à Sfax€€-€€€AméricainePizza",
                Latitude = 34.767470149514516,
                Longitude = 10.747181782575737,
                UrlLogo = "https://scontent.ftun10-1.fna.fbcdn.net/v/t39.30808-6/263979316_2388023538006788_2725964595273535910_n.png?_nc_cat=109&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=bxBqiH2mcOcAX8xOzwn&_nc_ht=scontent.ftun10-1.fna&oh=00_AT8umHHQDEgRVKWBe55jnXxvn7g_nn7_2knCKIlYcG-Ycg&oe=61E5262B",
                UrlPhoto = "https://scontent.ftun10-1.fna.fbcdn.net/v/t39.30808-6/271543337_2413134665495675_8425052987987141585_n.jpg?_nc_cat=110&ccb=1-5&_nc_sid=a26aad&_nc_ohc=S9SDTAeSlKQAX-NPuwh&_nc_ht=scontent.ftun10-1.fna&oh=00_AT-kAOObvRa9Yv2PN4TqhwiAkxZuPevgE7H0bleAEzjaqQ&oe=61E60848"
            }) ;
            
            modelBuilder.Entity<MenuRestaurant>().HasData(new MenuRestaurant
                {
                    Id = 1,
                    RestaurantId = 1,
                    MenuId = 1,
                }, new MenuRestaurant
                {
                    Id = 2,
                    RestaurantId = 1,
                    MenuId = 2,
                }, new MenuRestaurant
                {
                    Id = 3,
                    RestaurantId = 1,
                    MenuId = 3,
                }, new MenuRestaurant
                {
                    Id = 4,
                    RestaurantId = 2,
                    MenuId = 2,
                }, new MenuRestaurant
                {
                    Id = 5,
                    RestaurantId = 2,
                    MenuId = 4,
                }, new MenuRestaurant
                {
                    Id = 6,
                    RestaurantId = 3,
                    MenuId = 1,
                }, new MenuRestaurant
                {
                    Id = 7,
                    RestaurantId = 3,
                    MenuId = 2,
                }, new MenuRestaurant
                {
                    Id = 8,
                    RestaurantId = 3,
                    MenuId = 3,
                }, new MenuRestaurant
                {
                    Id = 9,
                    RestaurantId = 3,
                    MenuId = 7,
                }, new MenuRestaurant
                {
                    Id = 10,
                    RestaurantId = 4,
                    MenuId = 10,
                }, new MenuRestaurant
                {
                    Id = 11,
                    RestaurantId = 5,
                    MenuId = 8,
                }, new MenuRestaurant
                {
                    Id = 12,
                    RestaurantId = 5,
                    MenuId = 7,
                }, new MenuRestaurant
                {
                    Id = 13,
                    RestaurantId = 5,
                    MenuId = 4,
                }, new MenuRestaurant
                {
                    Id = 14,
                    RestaurantId = 5,
                    MenuId = 1,
                }, new MenuRestaurant
                {
                    Id = 15,
                    RestaurantId = 6,
                    MenuId = 11,
                }, new MenuRestaurant
                {
                    Id = 16,
                    RestaurantId = 6,
                    MenuId = 4,
                }, new MenuRestaurant
                {
                    Id = 17,
                    RestaurantId = 7,
                    MenuId = 4,
                }, new MenuRestaurant
                {
                    Id = 18,
                    RestaurantId = 7,
                    MenuId = 8,
                }, new MenuRestaurant
                {
                    Id = 19,
                    RestaurantId = 8,
                    MenuId = 11,
                }, new MenuRestaurant
                {
                    Id = 20,
                    RestaurantId = 8,
                    MenuId = 8,
                }, new MenuRestaurant
                {
                    Id = 21,
                    RestaurantId = 8,
                    MenuId = 4,
                }, new MenuRestaurant
                {
                    Id = 22,
                    RestaurantId = 8,
                    MenuId = 6,
                }, new MenuRestaurant
                {
                    Id = 23,
                    RestaurantId = 9,
                    MenuId = 8,
                }, new MenuRestaurant
                {
                    Id = 24,
                    RestaurantId = 9,
                    MenuId = 7,
                }, new MenuRestaurant
                {
                    Id = 25,
                    RestaurantId = 9,
                    MenuId = 5,
                }
            );
        }
    }
}