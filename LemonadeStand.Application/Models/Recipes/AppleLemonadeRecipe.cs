using LemonadeStand.Application.Contracts;
using LemonadeStand.Application.Models.Fruits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Application.Models.Recipes
{
    public class AppleLemonadeRecipe : IRecipe
    {
        public string Name => "Apple Lemonade";

        public Type AllowedFruit => typeof(Apple);

        public decimal ConsumptionPerGlass => 2.5m;

        public int PricePerGlass => 10;

    }
}
