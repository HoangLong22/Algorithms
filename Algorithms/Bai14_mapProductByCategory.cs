using Algorithms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai14_mapProductByCategory
    {
        public static List<Product> mapProductByCategory(List<Product> products, List<Category> categories)
        {
            List<Product> product_new = new List<Product>();
            foreach (var category in categories)
            {
                for (int i = 0; i < products.Count(); i++)
                    if (products[i].categoryId == category.id)
                    {
                        product_new.Add(new Product() { name = products[i].name, price = products[i].price, quality = products[i].quality, categoryId = products[i].categoryId, categoryName = category.name });
                    }
            }
            return product_new;
        }
    }
}
