using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai24_Queue
    {
      public static void testQueue()
        {

            var hoso_canxuly = new Queue<String>();

            hoso_canxuly.Enqueue("Hồ sơ A");
            hoso_canxuly.Enqueue("Hồ sơ B"); 
            hoso_canxuly.Enqueue("Hồ sơ C");
 
            while (hoso_canxuly.Count > 0)
            {
                var hs = hoso_canxuly.Dequeue();
                Console.WriteLine($"Xử lý {hs}, còn lại {hoso_canxuly.Count}");
            }

        }
    }
}
