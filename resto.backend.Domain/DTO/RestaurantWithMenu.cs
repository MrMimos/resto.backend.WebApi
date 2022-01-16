
namespace resto.backend.Domain.DTO
{
    public class RestaurantWithMenu
    {
        public string RestaurantName { get; set; }
        public string Description_Resto { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string UrlPhoto_R { get; set; }
        public string UrlLogo_R { get; set; }
        public string MenuName { get; set; }
        public string Description_Menu { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Time { get; set; }
        public string UrlPhoto_M { get; set; }
        public string UrlLogo_M{ get; set; }
        
    }
}
