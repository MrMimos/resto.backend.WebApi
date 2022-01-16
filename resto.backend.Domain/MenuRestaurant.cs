using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace resto.backend.Domain
{
    public class MenuRestaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public Restaurant Restaurant { get; private set; }
        public long RestaurantId { get; set; }

        public Menu Menu { get; private set; }
        public long MenuId { get; set; }
    }
}