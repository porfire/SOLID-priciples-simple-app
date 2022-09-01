﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_example
{
    public static class Extension
    {
        public static PriceTagMaker GetPriceTagMaker(this Product product)
        {
            switch (product.Type)
            {
                case "Drink":
                    return new DrinkTypePriceTagMaker();

                case "Fruit":
                    return new FruitTypePriceTagMaker();

                default:
                    return new PriceTagMaker();
            }
        }
    }

}
