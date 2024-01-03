using System.ComponentModel.DataAnnotations;

namespace LemonadeStand.Application.DTOs
{
    public class OrderDto
    {

        [Required]
        public string Recipe { get; set; }

        [Required]
        [MinLength(0)]
        public int OrderedGlassQuantity { get; set; }

        [Required]
        [MinLength(0)]
        public int MoneyPaid { get; set; }

        [MinLength(0)]
        public int ApplesAdded { get; set; }

        [MinLength(0)]
        public int MelonsAdded { get; set; }

        [MinLength(0)]
        public int OrangesAdded { get; set; }
    }
}
