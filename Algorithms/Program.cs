using Algorithms.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        public static void Product(Product product)
        {
            Console.WriteLine("Product {" + "Name: " + product.name + ", " + "Price: "+ product.price + ", " + "Quality: " + product.quality + ", " + "Category: " + product.categoryId + "}");
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { name = "CPU", price = 750, quality = 10, categoryId = 1});
            products.Add(new Product() { name = "RAM", price = 50, quality = 2, categoryId = 2 });
            products.Add(new Product() { name = "HDD", price = 70, quality = 1, categoryId = 2 });
            products.Add(new Product() { name = "Main", price = 400, quality = 3, categoryId = 1 });
            products.Add(new Product() { name = "Keyboard", price = 30, quality = 8, categoryId = 4 });
            products.Add(new Product() { name = "Mouse", price = 25, quality = 50, categoryId = 4 });
            products.Add(new Product() { name = "VGA", price = 60, quality = 35, categoryId = 3 });
            products.Add(new Product() { name = "Monitor", price = 120, quality = 28, categoryId = 2 });
            products.Add(new Product() { name = "Case", price = 120, quality = 28, categoryId = 5 });

            List<Category> categories = new List<Category>();
            categories.Add(new Category() { id = 1, name = "Computer" });
            categories.Add(new Category() { id = 2, name = "Memory" });
            categories.Add(new Category() { id = 3, name = "Card" });
            categories.Add(new Category() { id = 4, name = "Acsesory" });

            List<Menu> menu = new List<Menu>();
            menu.Add(new Menu() { id = 1, title = "Thể thao", parentId = 0 });
            menu.Add(new Menu() { id = 2, title = "Xã hội", parentId = 0 });
            menu.Add(new Menu() { id = 3, title = "Thể thao trong nước", parentId = 1 });
            menu.Add(new Menu() { id = 4, title = "Giao thông", parentId = 2 });
            menu.Add(new Menu() { id = 5, title = "Môi trường", parentId = 2 });
            menu.Add(new Menu() { id = 6, title = "Thể thao quốc tế", parentId = 1 });
            menu.Add(new Menu() { id = 7, title = "Giao thông ùn tắc", parentId = 4 });
            menu.Add(new Menu() { id = 8, title = "Môi trường đô thị", parentId = 5 });

            Console.WriteLine("Danh sach Product");
            foreach (var product in products)
                Product(product);

            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine("Sap gia tu thap den cao:");
            List<Product> productssortByPrice = Bai11_sortByPrice.sortByPrice(products);
            foreach (var product in productssortByPrice)
                Product(product);

            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine("Sap ten có do dài tu thap den cao:");
            List<Product> productssortByName = Bai12_sortByName.sortByName(products);
            foreach (var product in productssortByName)
                Product(product);

            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine("Sap xep product co ten Category theo abc:");
            List<Product> productCategoryName = Bai13_sortByCategoryName.sortByCategoryName(products, categories);
            foreach (var product in productCategoryName)
                Product(product);

            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine("Danh sach Product co CategoryName");
            List<Product> mapProductByCategory = Bai14_mapProductByCategory.mapProductByCategory(products, categories);
            foreach (var product in mapProductByCategory)
            Console.WriteLine("Product {" + "Name: " + product.name + ", " + "Price: " + product.price + ", " + "Quality: " + product.quality + ", " + "Category: " + product.categoryId + "," + "CategoryName: " + product.categoryName + "}");

            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine("Product co gia nho nhat:");
            Product productMinPrice = Bai15_minByPrice.minByPrice(products);
                Product(productMinPrice);

            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine("Product co gia lon nhat:");
            Product productMaxPrice = Bai16_maxByPrice.maxByPrice(products);
            Product(productMaxPrice);

            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine("Luong:");
            Console.WriteLine(Bai21_calSalary.calSalary(1000, 2));
            Console.WriteLine(Bai21_calSalary.calSalary_recursive(1000, 2));

            Console.WriteLine("-----------------------------------------------------------\n");
            Console.WriteLine("So thang can gui tiet kiem: ");
            Console.WriteLine(Bai22_calMonth.calMonth(1000, 2));
            Console.WriteLine(Bai22_calMonth.CalMonth_recurse(1000, 2));

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Menu:");
            Bai23_printMenu.printMenu(menu);

            Console.ReadKey();
        }
    }
}
