using Algorithms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai12_sortByName
    {
        public static List<Product> sortByName(List<Product> products)
        {
            Product item;
            int holePosition;
            int i;

            for (i = 1; i < products.Count(); i++)
            {
                item = products[i];
                holePosition = i;
                while (holePosition > 0 && products[holePosition - 1].name.Length > item.name.Length)
                {
                    products[holePosition] = products[holePosition - 1];
                    holePosition = holePosition - 1;
                }
                if (holePosition != i)
                    products[holePosition] = item;
            }
            return products;
        }

        //public static List<Product>sortByNames(List<Product> products)
        //{
        // //SX Theo thuat toan Blue
        //Product item;
        //    int i, j;
        //    for (i = 0; i < products.Count() - 1; i++)
        //        for (j = 0; j < products.Count() - 1 - i; j++)
        //            if ((products[j].name).Length > (products[j + 1].name).Length)
        //            {
        //        item = products[j];
        //        products[j] = products[j + 1];
        //        products[j + 1] = item;
        //    }
        //    return products;
        //}
    }
}
