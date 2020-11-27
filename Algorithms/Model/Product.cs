using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Model
{
    class Product
    {
        public int id { set; get; }
        public string name { set; get; }
        public int categoryId { set; get; }
        public int price { set; get; }
        public int quality { set; get; }
        public string categoryName { set; get; }
    }
}
