
using LemonadeStand.Domain.Fruits;

namespace LemonadeStand.Domain.Recipes
{
    public class MelonLemonadeRecipe : IRecipe
    {
        public string Name => "Melon Lemonade";

        public Type AllowedFruit => typeof(Melon);

        public decimal ConsumptionPerGlass => 0.5m;

        public int PricePerGlass => 12;
    }
}
