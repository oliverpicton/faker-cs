using System;
using Faker.Extensions;

namespace Faker
{
    public class Commerce
    {
        public static string ProductName()
        {
            return Resources.Commerce.productNameAdjective.Split(Config.Separator).Random() + ' ' + Resources.Commerce.productNameMaterial.Split(Config.Separator).Random() + ' ' + Resources.Commerce.productName.Split(Config.Separator).Random();
        }

        public static string Department()
        {
            return Resources.Commerce.department.Split(Config.Separator).Random();
        }

        public static string Price()
        {
            return "##.##".Numerify();
        }
    }
}