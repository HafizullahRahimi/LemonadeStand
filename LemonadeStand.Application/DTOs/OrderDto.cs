using LemonadeStand.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Application.DTOs
{
    public class OrderDto
    {
        //[Required(ErrorMessage = "Vänligen ange name")]
        //[MaxLength(20, ErrorMessage = "Tecken är mer än 20 långa.")]
        //public Collection<IFruit> Fruits { get; set; }
        //public IRecipe Recipe { get; set; }


        [Required]
        public string Recipe { get; set; }

        [Required]
        [MinLength(0)]
        //[MaxLength(20, ErrorMessage = "Tecken är mer än 20 långa.")]
        public int OrderedGlassQuantity { get; set; }

        [Required]
        [MinLength(0)]
        public int MoneyPaid { get; set; }

        [MinLength(0)]
        public int ApplesAdded { get; set; }

        [MinLength(0)]
        public int MelonsAdded { get; set; }

        [MinLength(0)]
        public int OrangesAdded { get; set; }
    }
}
