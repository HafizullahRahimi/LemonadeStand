
using LemonadeStand.Domain.Fruits;

namespace LemonadeStand.Domain.Recipes
{
    public class OrangeLemonadeRecipe : IRecipe
    {
        public string Name => "Orange Lemonade";

        public Type AllowedFruit => typeof(Orange);

        public decimal ConsumptionPerGlass => 1;

        public int PricePerGlass => 9;
    }
}
