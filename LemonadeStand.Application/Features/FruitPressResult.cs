using LemonadeStand.Application.Contracts;
using LemonadeStand.Application.Models.Fruits;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Application.Features
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


        public string HandlePriceError()
        {
            //if (_recipe.AllowedFruit == typeof(Apple)){}
            string errorMess = null;
            //if (_orderedGlassQuantity == 0)
            //{
            //    errorMess = $"Select ordered quanity";
            //    return errorMess;
            //}

            int resultPrice = _recipe.PricePerGlass * _orderedGlassQuantity;
            //if (_moneyPaid == 0)
            //{
            //    errorMess = $"money only enough for 0 glass(es)! Money : {resultPrice} Needed!";
            //    return errorMess;
            //}


            if (_moneyPaid != resultPrice)
            {
                int glassQuantityCanBye = _moneyPaid / _recipe.PricePerGlass;
                errorMess = $"money only enough for {glassQuantityCanBye} glass(es)! Money : {resultPrice} Needed!";
            }

            return errorMess;

        }

        public string HandleConsumptionFruitError()
        {
            string errorMess = null;

           
            decimal consumptionFruit = Convert.ToDecimal(_orderedGlassQuantity) * _recipe.ConsumptionPerGlass;
            decimal consumptionFruitToInt = Convert.ToInt32(Math.Ceiling( consumptionFruit));

            if (consumptionFruitToInt != _fruits.Count)
            {
                errorMess = $"{consumptionFruitToInt} fruits are enough for {_orderedGlassQuantity} glass(es)! Allowed Fruit: {_recipe.AllowedFruit.Name}";
            }

            return errorMess;

        }
    }
}
