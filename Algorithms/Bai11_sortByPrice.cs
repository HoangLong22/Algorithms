using Algorithms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai11_sortByPrice
    {
        public static List<Product>sortByPrice(List<Product> products)
        {
            Product item;
            int i, j;
            for (i = 0; i < products.Count() - 1; i++)
                for (j = 0; j < products.Count() - 1 - i; j++)
                    if (products[j].price > products[j + 1].price)
                    {
                        item = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = item;
                    }
            return products;
        }
    }
}
