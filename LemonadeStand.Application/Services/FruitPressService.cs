using LemonadeStand.Infrastructure;
using System.Collections.ObjectModel;
using LemonadeStand.Domain.Fruits;
using LemonadeStand.Domain.Recipes;

namespace LemonadeStand.Application.Services
{
    public class FruitPressService : IFruitPressService
    {
        public FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity) => new FruitPressResult(recipe, fruits, moneyPaid, orderedGlassQuantity);
         
    }
}
