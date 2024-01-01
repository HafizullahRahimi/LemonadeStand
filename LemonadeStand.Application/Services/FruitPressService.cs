using LemonadeStand.Application.Contracts;
using LemonadeStand.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Application.Services
{
    public class FruitPressService : IFruitPressService
    {
        //public FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity)
        //{
        //    var result = new FruitPressResult(recipe, fruits, moneyPaid, orderedGlassQuantity);
        //    return result;
        //}

        public FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity) => new FruitPressResult(recipe, fruits, moneyPaid, orderedGlassQuantity);
         
        public string Test()
        {
            return "Test Service";
        }
    }
}
