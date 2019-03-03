using System.Collections;
using System.Collections.Generic;
using System;

namespace LanguageFeatures.Models
{
    public static class myExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> productParam)
        {
            decimal total = 0; 
            foreach(Product prod in productParam)
            {
                total += prod.Price;
            }
            return total;
        }
        public static IEnumerable<Product> FilterByCategory(
        this IEnumerable<Product> productEnum, string categoryParam)
        {
            foreach (Product prod in productEnum)
            {
                if (prod.Category == categoryParam)
                {
                    yield return prod;
                }
            }
        }
        public static IEnumerable<Product> Filter(
        this IEnumerable<Product> productEnum, Func<Product, bool> selectorParam)
        {
            foreach (Product prod in productEnum)
            {
                if (selectorParam(prod))
                {
                    yield return prod;
                }
            }
        }

    }

  
}