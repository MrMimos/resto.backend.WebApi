using System.Collections.Generic;
using resto.backend.Domain.DTO;

namespace resto.backend.Domain
{
    public interface IRestaurantRepository : IDataRepository<Restaurant>
    {
        IList<RestaurantWithMenu> GetRestaurantMenus();
        IList<RestaurantWithMenu> GetRestaurantMenusByRestaurantId(long id);
        IList<Menu> GetAllMenu();
    }
}
