

namespace LemonadeStand.Infrastructure
{
    internal interface IFruitPressResult 
    {
        int GetTotalPrice();
        int GetGlassQuantityCanBuy();
        int GetConsumptionFruit();
    }
}
