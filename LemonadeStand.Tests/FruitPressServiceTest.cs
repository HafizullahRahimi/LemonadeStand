using LemonadeStand.Application.Services;
using LemonadeStand.Domain.Fruits;
using LemonadeStand.Domain.Recipes;
using System.Collections.ObjectModel;
using FluentAssertions;
using FluentAssertions.Execution;
using LemonadeStand.Application.DTOs;
using System.Xml.Linq;


namespace LemonadeStand.Tests
{

    public class FruitPressServiceTest
    {


        [Fact]
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
            glassQuantityCanBuy.Should().Be(5);
            totalPrice.Should().Be(50);
            consumptionFruit.Should().Be(13);

        }

        [Fact]
        public void SuccessfulProductionOf8GlassesOfMelonLemonadeTest()
        {
            // Arrange
            IRecipe recipe = new MelonLemonadeRecipe() { };
            Collection<IFruit> fruits = new Collection<IFruit>();
            AddFruit(fruits, 4, new Melon() { });

            var fruitPressService = new FruitPressService();
            var produce = fruitPressService.Produce(recipe, fruits, 96, 8);

            // Act
            var glassQuantityCanBuy = produce.GetGlassQuantityCanBuy();
            var totalPrice = produce.GetTotalPrice();
            var consumptionFruit = produce.GetConsumptionFruit();

            // Assert
            glassQuantityCanBuy.Should().Be(8);
            totalPrice.Should().Be(96);
            consumptionFruit.Should().Be(4);
           
        }


        [Theory]
        [InlineData("Hafizullah Rahimi")]
        public void Test(string name)
        {
            // Arrange
            var myName = "Hafizullah Rahimi";
            using var _ = new AssertionScope();


            // Assert
            myName.Should().Be(name);
            myName.Should().StartWith(name.Substring(0, 3))
                .And.EndWith(name.Substring(name.Length - 3))
                .And.Contain(" ");
            //Assert.NotNull(name);
        }



        private void AddFruit(Collection<IFruit> fruits, int length, IFruit fruit)
        {

            for (int i = 0; i < length; i++)
            {
                fruits.Add(fruit);
            }

        }
    }
}
