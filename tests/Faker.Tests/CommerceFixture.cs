using System;
using NUnit.Framework;

namespace Faker.Tests
{
    [TestFixture]
    public class CommerceFixture
    {
        [Test]
        public void Should_Get_ProductName()
        {
            var product = Commerce.ProductName();
            Console.WriteLine(product);
            Assert.IsNotEmpty(product);
        }

        [Test]
        public void Should_Get_Price()
        {
            var price = Commerce.Price();
            Console.WriteLine(price);
            Assert.IsNotEmpty(price);            
        }

        [Test]
        public void Should_Get_Department()
        {
            var department = Commerce.Department();
            Console.WriteLine(department);

            Assert.IsNotEmpty(department);
        }
    }
}