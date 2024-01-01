using LemonadeStand.Application.Contracts;
using LemonadeStand.Application.Models.Fruits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Application.Models.Recipes
{
    public class MelonLemonadeRecipe : IRecipe
    {
        public string Name => "Melon Lemonade";

        public Type AllowedFruit => typeof(Melon);

        public decimal ConsumptionPerGlass => 0.5m;

        public int PricePerGlass => 12;
    }
}
