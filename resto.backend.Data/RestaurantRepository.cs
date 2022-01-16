using resto.backend.Domain;
using resto.backend.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto.backend.Data
{
    public class RestaurantRepository : IDataRepository<Restaurant>, IRestaurantRepository
    {
        private readonly RestaurantContext _restaurantContext;

        public RestaurantRepository(RestaurantContext context)
        {
            _restaurantContext = context;
        }
        public void Add(Restaurant entity)
        {
            _restaurantContext.Restaurant.Add(entity);
            _restaurantContext.SaveChanges();
        }

        public Restaurant Get(long id)
        {
            return _restaurantContext.Restaurant.FirstOrDefault(t => id.Equals(t.Id));
        }

        public IList<Restaurant> GetAll()
        {
            return _restaurantContext.Restaurant.ToList();
        }

        public IList<Menu> GetAllMenu()
        {
            return _restaurantContext.Menu.ToList();
        }

        public IList<RestaurantWithMenu> GetRestaurantMenus()
        {
            List<RestaurantWithMenu> restaurantWithMenu = new List<RestaurantWithMenu>();
            var restaurantMenus = _restaurantContext.MenuRestaurant.ToList();
            var restaurants = _restaurantContext.Restaurant.ToList();
            var menus = _restaurantContext.Menu.ToList();
            var query =
                from restaurant in restaurants
                join restaurantMenu in restaurantMenus on restaurant.Id equals restaurantMenu.RestaurantId
                join menu in menus on restaurantMenu.MenuId equals menu.Id
                select new RestaurantWithMenu
                {
                    RestaurantName = restaurant.Name,
                    Latitude = restaurant.Latitude,
                    Longitude = restaurant.Longitude,
                    UrlLogo_R = restaurant.UrlLogo,
                    UrlPhoto_R = restaurant.UrlPhoto,
                    MenuName = menu.Name,
                    Description_Menu = menu.Description,
                    Description_Resto = restaurant.Description,
                    Price = menu.Price,
                    Time = menu.Time,
                    Category = menu.Category,
                    UrlLogo_M = menu.UrlLogo,
                    UrlPhoto_M = menu.UrlPhoto,

                };
            foreach (var res in query)
            {
                restaurantWithMenu.Add(res);
            };
            return restaurantWithMenu;
        }

        public IList<RestaurantWithMenu> GetRestaurantMenusByRestaurantId(long id)
        {
            List<RestaurantWithMenu> restaurantWithMenu = new List<RestaurantWithMenu>();
            var restaurantMenus = _restaurantContext.MenuRestaurant.ToList();
            var restaurants = _restaurantContext.Restaurant.ToList();
            var menus = _restaurantContext.Menu.ToList();
            var query =
                from restaurant in restaurants
                join restaurantMenu in restaurantMenus on restaurant.Id equals restaurantMenu.RestaurantId
                join menu in menus on restaurantMenu.MenuId equals menu.Id
                where restaurant.Id == id
                select new RestaurantWithMenu
                {
                    RestaurantName = restaurant.Name,
                    Latitude = restaurant.Latitude,
                    Longitude = restaurant.Longitude,
                    UrlLogo_R = restaurant.UrlLogo,
                    UrlPhoto_R = restaurant.UrlPhoto,
                    MenuName = menu.Name,
                    Description_Menu = menu.Description,
                    Description_Resto = restaurant.Description,
                    Price = menu.Price,
                    Time = menu.Time,
                    Category = menu.Category,
                    UrlLogo_M = menu.UrlLogo,
                    UrlPhoto_M = menu.UrlPhoto,


                };
            foreach (var res in query)
            {
                restaurantWithMenu.Add(res);
            };
            return restaurantWithMenu;
        }


    }
}
