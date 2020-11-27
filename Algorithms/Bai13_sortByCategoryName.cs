using Algorithms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai13_sortByCategoryName
    {
        public static string getCategoryName(Product products, List<Category> categories)
        {
            string categoryName = "";
            for (int i = 0; i < categories.Count(); i++)
            {
                if (products.categoryId == categories[i].id)
                {
                    categoryName = categories[i].name;
                    products.categoryName = categories[i].name;
                }
            }
            return categoryName;
        }

        public static List<Product> sortByCategoryName(List<Product> products, List<Category> categories)
        {
            Product item;
            int indexMin;
            int i, j;
            for (i = 0; i < products.Count() - 1; i++)
            {
                indexMin = i;
                for (j = i + 1; j < products.Count(); j++)
                {
                    if (string.Compare(getCategoryName(products[j], categories), getCategoryName(products[indexMin], categories)) < 0)
                        indexMin = j;                 
                }
                if (indexMin != i)
                {
                    item = products[i];
                    products[i] = products[indexMin];
                    products[indexMin] = item;
                }
            }
            return products;
        }
    }
}
