using LemonadeStand.Infrastructure;
using System.Collections.ObjectModel;
using LemonadeStand.Domain.Fruits;
using LemonadeStand.Domain.Recipes;

namespace LemonadeStand.Application.Services
{
    public interface IFruitPressService
    {
        FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity);
    }
}
