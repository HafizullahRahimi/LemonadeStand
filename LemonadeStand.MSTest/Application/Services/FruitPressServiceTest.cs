using LemonadeStand.Infrastructure;
using LemonadeStand.Domain.Fruits;
using LemonadeStand.Domain.Recipes;
using LemonadeStand.Application.Services;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.MSTest.Application.Services
{
    [TestClass]
    public class FruitPressServiceTest
    {


        [TestMethod]
        public void SuccessfulProductionOf5GlassesOfAppleLemonadeTest()
        {
            // Arrange
            IRecipe recipe = new AppleLemonadeRecipe() { };
            Collection<IFruit> fruits = new Collection<IFruit>();
            AddFruit(fruits, 13, new Apple() { });
            
            var fruitPressService = new FruitPressService();
            var produce = fruitPressService.Produce(recipe, fruits, 50, 5);

            // Act
            var glassQuantityCanBuy = produce.GetGlassQuantityCanBuy();
            var totalPrice = produce.GetTotalPrice();
            var consumptionFruit = produce.GetConsumptionFruit();

            // Assert
            Assert.IsNotNull(glassQuantityCanBuy);
            Assert.AreEqual(5, glassQuantityCanBuy);

            Assert.IsNotNull(totalPrice);
            Assert.AreEqual(50, totalPrice);

            Assert.IsNotNull(consumptionFruit);
            Assert.AreEqual(13, consumptionFruit);

        }


        [TestMethod]
        public void SuccessfulProductionOf8GlassesOfMelonLemonadeTest()
        {
            // Arrange
            IRecipe recipe = new MelonLemonadeRecipe() { };
            Collection<IFruit> fruits = new Collection<IFruit>();
            AddFruit(fruits, 4, new Melon() { });

            var fruitPressService = new FruitPressService();
            var produce = fruitPressService.Produce(recipe, fruits, 96,8);

            // Act
            var glassQuantityCanBuy = produce.GetGlassQuantityCanBuy();
            var totalPrice = produce.GetTotalPrice();
            var consumptionFruit = produce.GetConsumptionFruit();

            // Assert
            Assert.IsNotNull(glassQuantityCanBuy);
            Assert.AreEqual(8, glassQuantityCanBuy);

            Assert.IsNotNull(totalPrice);
            Assert.AreEqual(96, totalPrice);


            Assert.IsNotNull(consumptionFruit);
            Assert.AreEqual(4, consumptionFruit);

        }


        private void AddFruit(Collection<IFruit> fruits,int length, IFruit fruit)
        {

            for (int i = 0; i < length; i++)
            {
                fruits.Add(fruit);
            }

        }
    }
}
