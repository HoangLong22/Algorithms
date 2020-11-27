using Algorithms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai16_maxByPrice
    {
        public static Product maxByPrice(List<Product> products)
        {
            Product productMax = products[0];
            foreach (var product in products)
            {
                if (productMax.price < product.price)
                {
                    productMax = product;
                }
            }
            return productMax;
        }
    }
}
