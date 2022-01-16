using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using resto.backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using resto.backend.Domain.DTO;

namespace resto.backend.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly ILogger<RestaurantController> _logger;
        private readonly IRestaurantRepository _restaurantRepository;


        public RestaurantController(ILogger<RestaurantController> logger, IRestaurantRepository restaurantRepository)
        {
            _logger = logger;
            _restaurantRepository = restaurantRepository;
        }

        [HttpGet]
        public IEnumerable<Restaurant> Get()
        {
            _logger.Log(LogLevel.Trace, "Get all restaurants");
            return _restaurantRepository.GetAll();

        }

        [HttpGet("Menu")]
        public IEnumerable<RestaurantWithMenu> GetRestaurantMenus()
        {
            _logger.Log(LogLevel.Trace, "Get all menu in restaurant");
            return _restaurantRepository.GetRestaurantMenus();

        }

        [HttpGet("Menu/{id}")]
        public IEnumerable<RestaurantWithMenu> GetRestaurantMenus(long id)
        {
            _logger.Log(LogLevel.Trace, "Get all menu in restaurant");
            return _restaurantRepository.GetRestaurantMenusByRestaurantId(id);

        }

        [HttpGet("{id}")]
        public Restaurant GetById(long id)
        {
            _logger.Log(LogLevel.Trace, "Get restaurant by Id");
            return _restaurantRepository.Get(id);

        }

        [HttpPost]
        public void Add(Restaurant restaurant)
        {
            _logger.Log(LogLevel.Trace, "Add restaurant");
            _restaurantRepository.Add(restaurant);
        }

        [HttpGet("Menus")]
        public IEnumerable<Menu> GetAllMenu()
        {
            _logger.Log(LogLevel.Trace, "Get all menu in restaurant");
            return _restaurantRepository.GetAllMenu();

        }
    }
}
