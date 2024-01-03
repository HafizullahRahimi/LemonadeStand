﻿using LemonadeStand.Application.Contracts;
using LemonadeStand.Application.Models.Fruits;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Application.Features
{
    public class FruitPressResult : IFruitPressResult
    {
        private readonly IRecipe _recipe;
        private readonly Collection<IFruit> _fruits;
        private readonly int _moneyPaid;
        private readonly int _orderedGlassQuantity;

        public FruitPressResult(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity)
        {
            _recipe = recipe;
            _fruits = fruits;
            _moneyPaid = moneyPaid;
            _orderedGlassQuantity = orderedGlassQuantity;
        }


        public int GetTotalPrice() => _recipe.PricePerGlass * _orderedGlassQuantity;
        public int GetGlassQuantityCanBuy() => _moneyPaid / _recipe.PricePerGlass;
        public int GetConsumptionFruit() => Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(_orderedGlassQuantity) * _recipe.ConsumptionPerGlass));

    }
}
