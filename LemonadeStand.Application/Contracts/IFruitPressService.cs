using LemonadeStand.Application.DTOs;
using System.Collections.ObjectModel;

namespace LemonadeStand.Application.Contracts
{
    public interface IFruitPressService
    {
        FruitPressResult Produce(
            IRecipe recipe,
            Collection<IFruit> fruits,
            int moneyPaid,
            int orderedGlassQuantity);

        string Test();
    }
}
