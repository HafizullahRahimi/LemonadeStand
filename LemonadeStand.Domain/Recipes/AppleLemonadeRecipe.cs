
using LemonadeStand.Domain.Fruits;

namespace LemonadeStand.Domain.Recipes
{
    public class AppleLemonadeRecipe : IRecipe
    {
        public string Name => "Apple Lemonade";

        public Type AllowedFruit => typeof(Apple);

        public decimal ConsumptionPerGlass => 2.5m;

        public int PricePerGlass => 10;

    }
}
