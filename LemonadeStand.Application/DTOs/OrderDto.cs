using LemonadeStand.Domain.Fruits;
using System.ComponentModel.DataAnnotations;

namespace LemonadeStand.Application.DTOs
{
    public enum Recipes
    {
        AppleLemonade,
        MelonLemonade,
        OrangeLemonade
    }
    public class OrderDto
    {

        public Recipes Recipe { get; set; }
        public int OrderedQuanity { get; set; }
        public int MoneyPaid { get; set; }
        public int ApplesAdded { get; set; }
        public int MelonsAdded { get; set; }
        public int OrangesAdded { get; set; }
    }
}
