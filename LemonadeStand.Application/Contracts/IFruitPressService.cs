using LemonadeStand.Application.Features;
using System.Collections.ObjectModel;

namespace LemonadeStand.Application.Contracts
{
    public interface IFruitPressService
    {
        FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity);
    }
}
