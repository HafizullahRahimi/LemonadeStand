using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Application.Contracts
{
    internal interface IFruitPressResult 
    {
        int GetTotalPrice();
        int GetGlassQuantityCanBuy();
        int GetConsumptionFruit();
    }
}
