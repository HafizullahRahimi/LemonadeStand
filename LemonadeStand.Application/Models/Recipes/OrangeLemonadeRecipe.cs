using LemonadeStand.Application.Contracts;
using LemonadeStand.Application.Models.Fruits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Application.Models.Recipes
{
    public class OrangeLemonadeRecipe : IRecipe
    {
        public string Name => "Orange Lemonade";

        public Type AllowedFruit => typeof(Orange);

        public decimal ConsumptionPerGlass => 1;

        public int PricePerGlass => 9;
    }
}
