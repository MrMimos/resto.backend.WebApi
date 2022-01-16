﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using resto.backend.Data;

namespace resto.backend.Data.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20220116171654_v5")]
    partial class v5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("resto.backend.Domain.Menu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlLogo")
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlPhoto")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Category = "Volaille",
                            Description = "Escalopes de dinde aux oignons confits extra fines",
                            Name = "Plat Escaloppe Panée",
                            Price = "12",
                            Time = "20",
                            UrlLogo = "https://cdn-icons.flaticon.com/png/512/737/premium/737956.png?token=exp=1642110601~hmac=0efd6e58af8dbc8f84751bf90f04732a",
                            UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353266/Flutter%2A/Filet-de-dinde-aux-oignons-sauce-au-yaourt_mhe6rj.jpg"
                        },
                        new
                        {
                            Id = 2L,
                            Category = "Sandwich",
                            Description = "Délicieux tacos au poulet parfumés au curcuma et une pincée de curry",
                            Name = "Sandwich Tacos",
                            Price = "7",
                            Time = "10",
                            UrlLogo = "https://cdn-icons-png.flaticon.com/512/3248/3248708.png",
                            UrlPhoto = "https://fac.img.pmdstatic.net/fit/http.3A.2F.2Fprd2-bone-image.2Es3-website-eu-west-1.2Eamazonaws.2Ecom.2Ffac.2F2019.2F01.2F03.2F9bdc34bd-6233-45cb-986e-df99523545f0.2Ejpeg/850x478/quality/90/crop-from/center/tacos-ces-sandwichs-hypercaloriques-sont-il-pires-que-des-burgers.jpeg"
                        },
                        new
                        {
                            Id = 3L,
                            Category = "Enfant",
                            Description = "Pizza Napolitaine + Plat frites + boisson",
                            Name = "Menu kidz",
                            Price = "10",
                            Time = "15",
                            UrlLogo = "https://cdn-icons.flaticon.com/png/512/2880/premium/2880484.png?token=exp=1642110670~hmac=fc13d60e943c62aff1aab81721d1a1f4",
                            UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642353265/Flutter%2A/recette-e23069-pizza-napolitaine_b9hamn.jpg"
                        },
                        new
                        {
                            Id = 4L,
                            Category = "Pasta",
                            Description = "Ce délicieux plat est fait avec un mélange de fruits de mer cuits dans une sauce tomate aux oignons, ail, coriandre, cumin, rocou et poudre de chili ou (harissa)",
                            Name = "Spaghetti aux Fruits de Mer",
                            Price = "18",
                            Time = "25",
                            UrlLogo = "https://cdn-icons-png.flaticon.com/512/3480/3480618.png",
                            UrlPhoto = "https://www.demotivateur.fr/images-buzz/cover/183468931257aa0017f2040_Sans-titre-19.jpg"
                        },
                        new
                        {
                            Id = 5L,
                            Category = "Sandiwtch",
                            Description = "sandwichs Makloub chawarma avec garniture complète et généreuse",
                            Name = "Sandwitch Makloub Chawarma",
                            Price = "6",
                            Time = "8",
                            UrlLogo = "https://cdn-icons-png.flaticon.com/512/3248/3248708.png",
                            UrlPhoto = "https://64.media.tumblr.com/957e7090276fcabd8556ea49bdf8e70b/ff24b503f365020e-b7/s1280x1920/6a0604a638d91e89048d79dd8c84267190997dbc.jpg"
                        },
                        new
                        {
                            Id = 6L,
                            Category = "Tunisien",
                            Description = "Composée d'olives, de thon, d'œufs cuits durs, de tomates, de piments verts et sans oublier l'huile d'olive vierge Tunisienne.",
                            Name = "Salade Tunisienne",
                            Price = "6",
                            Time = "10",
                            UrlLogo = "https://cdn-icons.flaticon.com/png/512/4855/premium/4855834.png?token=exp=1642110722~hmac=436a38f5d0107208a26951d7564df256",
                            UrlPhoto = "https://media.eggs.ca/assets/RecipePhotos/_resampled/FillWyIxMjgwIiwiNzIwIl0/Nicoise-Salad-022-LR.jpg"
                        },
                        new
                        {
                            Id = 7L,
                            Category = "Pizza",
                            Description = "Pizza au feu du bois bien garnies avec la viande de veau et les meilleurs fromages",
                            Name = "Pizza Viande Hachée",
                            Price = "12",
                            Time = "9",
                            UrlLogo = "https://cdn-icons.flaticon.com/png/512/3511/premium/3511307.png?token=exp=1642109103~hmac=f4af5385f7c8a3011dc012dde9bcd9f3",
                            UrlPhoto = "https://img.cuisineaz.com/660x660/2016-01-30/i90037-pizza-steaks-haches-tomates-et-mozzarella.jpg"
                        },
                        new
                        {
                            Id = 8L,
                            Category = "Pizza",
                            Description = "Pizza aux fruits de mer et pesto de persil-parmesan-citron",
                            Name = "Pizza fruit de mer",
                            Price = "18",
                            Time = "15",
                            UrlLogo = "https://cdn-icons.flaticon.com/png/512/3511/premium/3511307.png?token=exp=1642109103~hmac=f4af5385f7c8a3011dc012dde9bcd9f3",
                            UrlPhoto = "https://cuisine.nessma.tv/uploads/7/2020-11/747596a9f2f164eda4a451eef69669a0.jpg"
                        },
                        new
                        {
                            Id = 9L,
                            Category = "Sandwitch",
                            Description = "Sandwitch Tunisien aux thon et olives verts",
                            Name = "Sandwitch 3arbi",
                            Price = "18",
                            Time = "15",
                            UrlLogo = "https://cdn-icons-png.flaticon.com/512/3248/3248708.png",
                            UrlPhoto = "https://cuisine.nessma.tv/uploads/7/2020-06/c7d07b8fa720d596ed458e9c2399f3ba.png"
                        },
                        new
                        {
                            Id = 10L,
                            Category = "Grillade",
                            Description = "Brochette de viande d'angeau avec garniture et salades variées",
                            Name = "Brochette Viande d'agneau",
                            Price = "14",
                            Time = "20",
                            UrlLogo = "https://cdn-icons.flaticon.com/png/512/1791/premium/1791711.png?token=exp=1642110026~hmac=08246dcf7439648d5676a3ef2c276c64",
                            UrlPhoto = "https://cuisine.nessma.tv/uploads/1/2019-07/4701dfb2dbe5c7e3086187b1f738d8c2.jpg"
                        },
                        new
                        {
                            Id = 11L,
                            Category = "Poissons",
                            Description = "Grillade de poissons de saison bien garnies avec salade verte et frites",
                            Name = "Grillade de Poissons",
                            Price = "22",
                            Time = "25",
                            UrlLogo = "https://cdn-icons.flaticon.com/png/512/783/premium/783043.png?token=exp=1642110950~hmac=737a2ec2f23d244f442bf8391867dfb4",
                            UrlPhoto = "http://restodino.com/wp-content/uploads/2020/04/Grillade-poisson-pour-cest-bon.jpg"
                        });
                });

            modelBuilder.Entity("resto.backend.Domain.MenuRestaurant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("MenuId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RestaurantId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("MenuRestaurant");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            MenuId = 1L,
                            RestaurantId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            MenuId = 2L,
                            RestaurantId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            MenuId = 3L,
                            RestaurantId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            MenuId = 2L,
                            RestaurantId = 2L
                        },
                        new
                        {
                            Id = 5L,
                            MenuId = 4L,
                            RestaurantId = 2L
                        },
                        new
                        {
                            Id = 6L,
                            MenuId = 1L,
                            RestaurantId = 3L
                        },
                        new
                        {
                            Id = 7L,
                            MenuId = 2L,
                            RestaurantId = 3L
                        },
                        new
                        {
                            Id = 8L,
                            MenuId = 3L,
                            RestaurantId = 3L
                        },
                        new
                        {
                            Id = 9L,
                            MenuId = 7L,
                            RestaurantId = 3L
                        },
                        new
                        {
                            Id = 10L,
                            MenuId = 10L,
                            RestaurantId = 4L
                        },
                        new
                        {
                            Id = 11L,
                            MenuId = 8L,
                            RestaurantId = 5L
                        },
                        new
                        {
                            Id = 12L,
                            MenuId = 7L,
                            RestaurantId = 5L
                        },
                        new
                        {
                            Id = 13L,
                            MenuId = 4L,
                            RestaurantId = 5L
                        },
                        new
                        {
                            Id = 14L,
                            MenuId = 1L,
                            RestaurantId = 5L
                        },
                        new
                        {
                            Id = 15L,
                            MenuId = 11L,
                            RestaurantId = 6L
                        },
                        new
                        {
                            Id = 16L,
                            MenuId = 4L,
                            RestaurantId = 6L
                        },
                        new
                        {
                            Id = 17L,
                            MenuId = 4L,
                            RestaurantId = 7L
                        },
                        new
                        {
                            Id = 18L,
                            MenuId = 8L,
                            RestaurantId = 7L
                        },
                        new
                        {
                            Id = 19L,
                            MenuId = 11L,
                            RestaurantId = 8L
                        },
                        new
                        {
                            Id = 20L,
                            MenuId = 8L,
                            RestaurantId = 8L
                        },
                        new
                        {
                            Id = 21L,
                            MenuId = 4L,
                            RestaurantId = 8L
                        },
                        new
                        {
                            Id = 22L,
                            MenuId = 6L,
                            RestaurantId = 8L
                        },
                        new
                        {
                            Id = 23L,
                            MenuId = 8L,
                            RestaurantId = 9L
                        },
                        new
                        {
                            Id = 24L,
                            MenuId = 7L,
                            RestaurantId = 9L
                        },
                        new
                        {
                            Id = 25L,
                            MenuId = 5L,
                            RestaurantId = 9L
                        });
                });

            modelBuilder.Entity("resto.backend.Domain.Restaurant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlLogo")
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlPhoto")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Restaurant");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Kechmech Spécialité sandwich italien et tunisien ",
                            Latitude = 34.742112661488967,
                            Longitude = 10.756184298471036,
                            Name = "Kechmech",
                            UrlLogo = "https://img.restaurantguru.com/r1c8-Kechmech-logo.jpg",
                            UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642352966/Flutter%2A/1-2_gxehd6.jpg"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "TONTON spécialisée Restaurants, Restauration Rapide - Fast-foods - Rotisseries - Sandwicheries.",
                            Latitude = 34.742331830934425,
                            Longitude = 10.754495972724662,
                            Name = "TonTon",
                            UrlLogo = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642073508/Flutter%2A/download_cfbh7c.jpg",
                            UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642339252/Flutter%2A/tonton_sor8iy.jpg"
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Papillon spécialisée hamburgers, pizzas, poulets et sandwichs - Fast-foods.",
                            Latitude = 34.766305492786053,
                            Longitude = 10.74422188627223,
                            Name = "Papillon",
                            UrlLogo = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642107567/Flutter%2A/download_ocqgvv.jpg",
                            UrlPhoto = "https://10619-2.s.cdn12.com/rests/original/312_508908254.jpg"
                        },
                        new
                        {
                            Id = 4L,
                            Description = "CUISINES Tunisienne, Steakhouse, Méditerranéenne, Barbecue/Grillades.",
                            Latitude = 34.736310266430806,
                            Longitude = 10.762069369081546,
                            Name = "Safoud Abid",
                            UrlLogo = "https://scontent.ftun10-1.fna.fbcdn.net/v/t1.18169-9/17862618_1397221710340475_6119642009369072306_n.jpg?_nc_cat=103&ccb=1-5&_nc_sid=730e14&_nc_ohc=IMahhA0T8NMAX-TJB4h&_nc_oc=AQm0Uj-eT753bUqeMH7OWEM-G1DSMBrYRwWqSaPD70DaSVocc5VmHW8ZrIBYwmsRnt4&_nc_ht=scontent.ftun10-1.fna&oh=00_AT_ye4wGOB_fppcvi0roaopTcDarmwS-VYvCqQH_BldZHw&oe=6205B7B3",
                            UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642352965/Flutter%2A/safoud-050816-3_yq5yqm.jpg"
                        },
                        new
                        {
                            Id = 5L,
                            Description = "L'Agora Resto restaurants à Sfax - Italienne Méditerranéenne Tunisienne.",
                            Latitude = 34.757921884394804,
                            Longitude = 10.733915869081951,
                            Name = "L'Agora Resto",
                            UrlLogo = "https://scontent.ftun16-1.fna.fbcdn.net/v/t1.6435-9/54222310_836384513363419_4827507691259691008_n.png?_nc_cat=104&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=iFCzV15PALkAX_gc-vR&_nc_ht=scontent.ftun16-1.fna&oh=00_AT-lribzULeNpiVZ5D4wE_SNV0pm2q7SGJ27nu_excsa8Q&oe=62053AFC",
                            UrlPhoto = "https://res.cloudinary.com/dh1sbp9ms/image/upload/v1642352963/Flutter%2A/20180316_145704-300x250_nvnlz4.jpg"
                        },
                        new
                        {
                            Id = 6L,
                            Description = "Borj dhiafa restaurants à Sfax - Française Internationale Méditerranéenne.",
                            Latitude = 34.725339319152624,
                            Longitude = 10.723978013258671,
                            Name = "Borj dhiafa",
                            UrlLogo = "https://www.hotelborjdhiafa.com//wp-content/gallery/slide_index/slide1.jpg",
                            UrlPhoto = "https://lh5.googleusercontent.com/p/AF1QipOMmKu6XI9Ma10yrvet6KJjv4NHciX_hgT3I35h=w253-h168-k-no"
                        },
                        new
                        {
                            Id = 7L,
                            Description = "Restaurant Baghdad restaurants à Sfax - Fruits de mer & Poisson Méditerranéenne Tunisienne",
                            Latitude = 34.73359819271915,
                            Longitude = 10.76088911141056,
                            Name = "Restaurant Baghdad",
                            UrlLogo = "https://scontent.ftun16-1.fna.fbcdn.net/v/t31.18172-8/11416405_847062178739642_3869777224013111764_o.jpg?_nc_cat=100&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=WizAnxIGY5AAX9kE3F9&_nc_ht=scontent.ftun16-1.fna&oh=00_AT_2PxY0mHjjorfJGxUjJLLzA8SoEbPEinWwlhVW_0tK2g&oe=6206CBDE",
                            UrlPhoto = "https://img.restaurantguru.com/rb9b-Restaurant-Baghdad-interior.jpg"
                        },
                        new
                        {
                            Id = 8L,
                            Description = "La voile blanche restaurants à Sfax - Fruits de mer & Poisson Méditerranéenne Tunisienne",
                            Latitude = 34.753014480384401,
                            Longitude = 10.757744442094603,
                            Name = "La voile blanche",
                            UrlLogo = "https://scontent.ftun10-1.fna.fbcdn.net/v/t31.18172-8/16143476_1180660678696363_7890264209456336271_o.jpg?_nc_cat=106&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=6RQwaPB25VcAX9rRKQW&_nc_ht=scontent.ftun10-1.fna&oh=00_AT_Fwq1nsclgt7cfMQ2Jc4H7zottlYq-PW3Mh6RQWpPrxQ&oe=62061A61",
                            UrlPhoto = "https://scontent.ftun10-1.fna.fbcdn.net/v/t1.6435-9/s960x960/122225003_3328847167211026_2998804788314153198_n.jpg?_nc_cat=102&ccb=1-5&_nc_sid=8bfeb9&_nc_ohc=G8T1hRmJr8QAX9wtvvd&_nc_ht=scontent.ftun10-1.fna&oh=00_AT-td6rn0hE4dDlxlzTarAd-969xnnKVQ5nwhKgYDUEwFw&oe=6204540B"
                        },
                        new
                        {
                            Id = 9L,
                            Description = "Farm Slice Pizza restaurant à Sfax€€-€€€AméricainePizza",
                            Latitude = 34.767470149514516,
                            Longitude = 10.747181782575737,
                            Name = "Farm Slice Pizza",
                            UrlLogo = "https://scontent.ftun10-1.fna.fbcdn.net/v/t39.30808-6/263979316_2388023538006788_2725964595273535910_n.png?_nc_cat=109&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=bxBqiH2mcOcAX8xOzwn&_nc_ht=scontent.ftun10-1.fna&oh=00_AT8umHHQDEgRVKWBe55jnXxvn7g_nn7_2knCKIlYcG-Ycg&oe=61E5262B",
                            UrlPhoto = "https://scontent.ftun10-1.fna.fbcdn.net/v/t39.30808-6/271543337_2413134665495675_8425052987987141585_n.jpg?_nc_cat=110&ccb=1-5&_nc_sid=a26aad&_nc_ohc=S9SDTAeSlKQAX-NPuwh&_nc_ht=scontent.ftun10-1.fna&oh=00_AT-kAOObvRa9Yv2PN4TqhwiAkxZuPevgE7H0bleAEzjaqQ&oe=61E60848"
                        });
                });

            modelBuilder.Entity("resto.backend.Domain.MenuRestaurant", b =>
                {
                    b.HasOne("resto.backend.Domain.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("resto.backend.Domain.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Restaurant");
                });
#pragma warning restore 612, 618
        }
    }
}
