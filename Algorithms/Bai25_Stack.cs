using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai25_Stack
    {
        public static void testStack()
        {
            var nhakho = new Stack<string>();

            nhakho.Push("Sản phẩm A");
            nhakho.Push("Sản phẩm B");
            nhakho.Push("Sản phẩm C");

            // Xếp vào sau thì tháo ra trước
            while (nhakho.Count > 0)
            {
                var sp = nhakho.Pop();
                Console.WriteLine($"Bốc dỡ {sp} / còn lại {nhakho.Count}");
            }

        }
    }
}
