using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Application.Contracts
{
    public interface IRecipe
    {
        string Name { get; }
        Type AllowedFruit { get; }
        decimal ConsumptionPerGlass { get; }
        int PricePerGlass { get; }
    }
}
