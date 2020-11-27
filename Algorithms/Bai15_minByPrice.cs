using Algorithms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai15_minByPrice
    {
        public static Product minByPrice(List<Product> products)
        {
            Product productMin = products[0];
            foreach (var product in products)
            {
                if (productMin.price > product.price)
                {
                    productMin = product;
                }
            }
            return productMin;
        }
    }
}
