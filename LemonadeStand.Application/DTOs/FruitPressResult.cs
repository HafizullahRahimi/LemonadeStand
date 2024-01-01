using LemonadeStand.Application.Contracts;
using LemonadeStand.Application.Models.Fruits;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Application.DTOs
{
    public class FruitPressResult
    {
        private readonly IRecipe _recipe;
        private readonly Collection<IFruit> _fruits;
        private readonly int _moneyPaid;
        private readonly int _orderedGlassQuantity;

        public FruitPressResult(
            IRecipe recipe,
            Collection<IFruit> fruits,
            int moneyPaid,
            int orderedGlassQuantity)
        {
            _recipe = recipe;
            _fruits = fruits;
            _moneyPaid = moneyPaid;
            _orderedGlassQuantity = orderedGlassQuantity;
        }


        public string PriceError()
        {
            //if (_recipe.AllowedFruit == typeof(Apple)){}
            string errorMess = null;
            int resultPrice = _recipe.PricePerGlass * _orderedGlassQuantity;
            if (_moneyPaid == 0)
            {
                errorMess = $"money only enough for 0 glass(es)! Money : {resultPrice} Needed!";
            }

            if (_moneyPaid != resultPrice)
            {
                int glassQuantityCanBye = _moneyPaid / _recipe.PricePerGlass;
                errorMess = $"money only enough for {glassQuantityCanBye} glass(es)! Money : {resultPrice} Needed!";
            }

            return errorMess;

        }

        public string ConsumptionFruitError(string message)
        {
            string errorMess = null;

            int consumptionFruit = Convert.ToInt32(Convert.ToDecimal(_orderedGlassQuantity) * _recipe.ConsumptionPerGlass);
            if (consumptionFruit != _fruits.Count)
            {
                errorMess = $"fruits are not enough for {_orderedGlassQuantity} glass(es)! Fruits : {consumptionFruit} Needed!";
            }

            return errorMess;

        }
    }
}
